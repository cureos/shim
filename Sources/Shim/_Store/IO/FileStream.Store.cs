/*
 *  Copyright (c) 2013-2016, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of Shim.
 *
 *  Shim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  Shim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with Shim. If not, see <http://www.gnu.org/licenses/>.
 */

using System.Threading.Tasks;
using Windows.Storage;

namespace System.IO
{
    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.FileStream"]/*' />
    public sealed class FileStream : Stream
    {
        #region FIELDS

        private Stream _internalStream;
        private bool _disposed = false;

        #endregion
        
        #region CONSTRUCTORS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.#ctor(System.String,System.IO.FileMode)"]/*' />
        public FileStream(string path, FileMode mode)
            : this(path, mode, FileAccess.ReadWrite, FileShare.Read)
        {
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.#ctor(System.String,System.IO.FileMode,System.IO.FileAccess)"]/*' />
        public FileStream(string path, FileMode mode, FileAccess access)
            : this(path, mode, access, FileShare.Read)
        {
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.#ctor(System.String,System.IO.FileMode,System.IO.FileAccess,System.IO.FileShare)"]/*' />
        public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
        {
            try
            {
                _internalStream = Task.Run(async () =>
                {
                    StorageFile file;
                    Stream stream;
                    long position;
                    switch (mode)
                    {
                        case FileMode.Create:
                        case FileMode.Truncate:
                            file = await FileHelper.CreateStorageFileAsync(path);
                            position = 0;
                            break;
                        case FileMode.CreateNew:
                            if (File.Exists(path))
                                throw new IOException("File mode is CreateNew, but file already exists.");
                            file = await FileHelper.CreateStorageFileAsync(path);
                            position = 0;
                            break;
                        case FileMode.OpenOrCreate:
                            if (File.Exists(path))
                            {
                                file = await FileHelper.GetStorageFileAsync(path);
                            }
                            else
                            {
                                file = await FileHelper.CreateStorageFileAsync(path);
                            }
                            position = 0;
                            break;
                        case FileMode.Open:
                            if (!File.Exists(path))
                                throw new FileNotFoundException("File mode is Open, but file does not exist.");
                            file = await FileHelper.GetStorageFileAsync(path);
                            position = 0;
                            break;
                        case FileMode.Append:
                            if (File.Exists(path))
                            {
                                file = await FileHelper.GetStorageFileAsync(path);
                                position = (long)(await file.GetBasicPropertiesAsync()).Size;
                            }
                            else
                            {
                                file = await FileHelper.CreateStorageFileAsync(path);
                                position = 0;
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("mode");
                    }
                    switch (access)
                    {
                        case FileAccess.ReadWrite:
                        case FileAccess.Write:
                            stream = await file.OpenStreamForWriteAsync();
                            break;
                        case FileAccess.Read:
                            stream = await file.OpenStreamForReadAsync();
                            break;
                        default:
                            throw new ArgumentException("Unsupported file access type", "access");
                    }
                    stream.Seek(position, SeekOrigin.Begin);
                    return stream;
                }).Result;

                _disposed = false;
                Name = path;
            }
            catch
            {
                _internalStream = null;
                _disposed = true;
                Name = String.Empty;
            }
        }

        #endregion

        #region PROPERTIES

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.CanRead"]/*' />
        public override bool CanRead
        {
            get { return _internalStream.CanRead; }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.CanSeek"]/*' />
        public override bool CanSeek
        {
            get { return _internalStream.CanSeek; }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.CanWrite"]/*' />
        public override bool CanWrite
        {
            get { return _internalStream.CanWrite; }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.Length"]/*' />
        public override long Length
        {
            get { return _internalStream.Length; }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.Position"]/*' />
        public override long Position
        {
            get { return _internalStream.Position; }
            set { _internalStream.Position = value; }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.Name"]/*' />
        public string Name { get; private set; }

        #endregion

        #region METHODS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Flush"]/*' />
        public override void Flush()
        {
            _internalStream.Flush();
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Read(System.Byte[],System.Int32,System.Int32)"]/*' />
        public override int Read(byte[] array, int offset, int count)
        {
            return _internalStream.Read(array, offset, count);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Seek(System.Int64,System.IO.SeekOrigin)"]/*' />
        public override long Seek(long offset, SeekOrigin origin)
        {
            return _internalStream.Seek(offset, origin);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.SetLength(System.Int64)"]/*' />
        public override void SetLength(long value)
        {
            _internalStream.SetLength(value);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Write(System.Byte[],System.Int32,System.Int32)"]/*' />
        public override void Write(byte[] array, int offset, int count)
        {
            _internalStream.Write(array, offset, count);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Dispose(System.Boolean)"]/*' />
        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;

            _internalStream.Dispose();
            _internalStream = null;

            base.Dispose(disposing);
            _disposed = true;
        }

        #endregion
    }
}