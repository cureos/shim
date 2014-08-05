/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSShim.
 *
 *  CSShim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  CSShim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with CSShim. If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.Net.Sockets
{
    using System.IO;

    public sealed class NetworkStream : Stream
    {
        #region METHODS

        public override void Flush()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public override void SetLength(long value)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion

        #region PROPERTIES

        public override bool CanRead
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        public override bool CanSeek
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        public override bool CanWrite
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        public override long Length
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        public override long Position {
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