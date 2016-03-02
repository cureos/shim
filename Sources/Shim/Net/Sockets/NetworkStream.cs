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

namespace System.Net.Sockets
{
    using System.IO;

    /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Sockets.NetworkStream"]/*' />
    public sealed class NetworkStream : Stream
    {
        #region METHODS

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.Flush"]/*' />
        public override void Flush()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.Read(System.Byte[],System.Int32,System.Int32)"]/*' />
        public override int Read(byte[] buffer, int offset, int size)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.Seek(System.Int64,System.IO.SeekOrigin)"]/*' />
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.SetLength(System.Int64)"]/*' />
        public override void SetLength(long value)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.Write(System.Byte[],System.Int32,System.Int32)"]/*' />
        public override void Write(byte[] buffer, int offset, int size)
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion

        #region PROPERTIES

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.CanRead"]/*' />
        public override bool CanRead
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.CanSeek"]/*' />
        public override bool CanSeek
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.CanWrite"]/*' />
        public override bool CanWrite
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.Length"]/*' />
        public override long Length
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.Position"]/*' />
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
        
        #endregion
    }
}