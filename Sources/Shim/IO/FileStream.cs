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

namespace System.IO
{
    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.FileStream"]/*' />
    public sealed class FileStream : Stream
    {
        #region CONSTRUCTORS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.#ctor(System.String,System.IO.FileMode)"]/*' />
        public FileStream(string path, FileMode mode)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.#ctor(System.String,System.IO.FileMode,System.IO.FileAccess)"]/*' />
        public FileStream(string path, FileMode mode, FileAccess access)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.#ctor(System.String,System.IO.FileMode,System.IO.FileAccess,System.IO.FileShare)"]/*' />
        public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.CanRead"]/*' />
        public override bool CanRead { get { throw new PlatformNotSupportedException("PCL"); } }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.CanSeek"]/*' />
        public override bool CanSeek { get { throw new PlatformNotSupportedException("PCL"); } }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.CanWrite"]/*' />
        public override bool CanWrite { get { throw new PlatformNotSupportedException("PCL"); } }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.Length"]/*' />
        public override long Length { get { throw new PlatformNotSupportedException("PCL"); } }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.Position"]/*' />
        public override long Position
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
            set
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileStream.Name"]/*' />
        public string Name { get { throw new PlatformNotSupportedException("PCL"); } }
        
        #endregion

        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Flush"]/*' />
        public override void Flush() { throw new PlatformNotSupportedException("PCL"); }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Read(System.Byte[],System.Int32,System.Int32)"]/*' />
        public override int Read(byte[] array, int offset, int count) { throw new PlatformNotSupportedException("PCL"); }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Seek(System.Int64,System.IO.SeekOrigin)"]/*' />
        public override long Seek(long offset, SeekOrigin origin) { throw new PlatformNotSupportedException("PCL"); }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.SetLength(System.Int64)"]/*' />
        public override void SetLength(long value) { throw new PlatformNotSupportedException("PCL"); }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileStream.Write(System.Byte[],System.Int32,System.Int32)"]/*' />
        public override void Write(byte[] array, int offset, int count) { throw new PlatformNotSupportedException("PCL"); }

        #endregion
    }
}