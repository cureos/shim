/*
 *  Copyright (c) 2013-2015, Cureos AB.
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
    public sealed class FileStream : Stream
    {
        #region FIELDS

        private Stream _internalStream;
        private bool _disposed = false;

        #endregion
        
        #region CONSTRUCTORS

        public FileStream(string path, FileMode mode) : this(path, mode, FileAccess.ReadWrite, FileShare.Read)
        {
        }

        public FileStream(string path, FileMode mode, FileAccess access)
            : this(path, mode, access, FileShare.Read)
        {
        }

        public FileStream(string name, FileMode mode, FileAccess access, FileShare share)
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
                            file = await FileHelper.CreateStorageFileAsync(name);
                            position = 0;
                            break;
                        case FileMode.CreateNew:
                            if (File.Exists(name))
                                throw new IOException("File mode is CreateNew, but file already exists.");
                            file = await FileHelper.CreateStorageFileAsync(name);
                            position = 0;
                            break;
                        case FileMode.OpenOrCreate:
                            if (File.Exists(name))
                            {
                                file = await FileHelper.GetStorageFileAsync(name);
                            }
                            else
                            {
                                file = await FileHelper.CreateStorageFileAsync(name);
                            }
                            position = 0;
                            break;
                        case FileMode.Open:
                            if (!File.Exists(name))
                                throw new FileNotFoundException("File mode is Open, but file does not exist.");
                            file = await FileHelper.GetStorageFileAsync(name);
                            position = 0;
                            break;
                        case FileMode.Append:
                            if (File.Exists(name))
                            {
                                file = await FileHelper.GetStorageFileAsync(name);
                                position = (long)(await file.GetBasicPropertiesAsync()).Size;
                            }
                            else
                            {
                                file = await FileHelper.CreateStorageFileAsync(name);
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
                Name = name;
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

        public override bool CanRead
        {
            get { return _internalStream.CanRead; }
        }

        public override bool CanSeek
        {
            get { return _internalStream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return _internalStream.CanWrite; }
        }

        public override long Length
        {
            get { return _internalStream.Length; }
        }

        public override long Position
        {
            get { return _internalStream.Position; }
            set { _internalStream.Position = value; }
        }

        public string Name { get; private set; }

        #endregion

        #region METHODS

        public override void Flush()
        {
            _internalStream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return _internalStream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _internalStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _internalStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _internalStream.Write(buffer, offset, count);
        }

        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;

            _internalStream.Dispose();
            _internalStream = null;

            base.Dispose(disposing);
            _disposed = true;
        }

        private static FileAccessMode GetFileAccessMode(FileAccess access)
        {
            switch (access)
            {
                case FileAccess.Read:
                    return FileAccessMode.Read;
                case FileAccess.ReadWrite:
                case FileAccess.Write:
                    return FileAccessMode.ReadWrite;
                default:
                    throw new ArgumentOutOfRangeException("access");
            }
        }

        #endregion
    }
}