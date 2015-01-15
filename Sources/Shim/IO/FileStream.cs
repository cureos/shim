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

namespace System.IO
{
	public sealed class FileStream : Stream
	{
		#region CONSTRUCTORS

		public FileStream(string path, FileMode mode)
		{
            throw new PlatformNotSupportedException("PCL");
		}

        public FileStream(string path, FileMode mode, FileAccess access)
        {
            throw new PlatformNotSupportedException("PCL");
        }

		public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
		{
            throw new PlatformNotSupportedException("PCL");
		}

	    #endregion

		#region PROPERTIES

        public override bool CanRead { get { throw new PlatformNotSupportedException("PCL"); } }

        public override bool CanSeek { get { throw new PlatformNotSupportedException("PCL"); } }

        public override bool CanWrite { get { throw new PlatformNotSupportedException("PCL"); } }

        public override long Length { get { throw new PlatformNotSupportedException("PCL"); } }

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

        public string Name { get { throw new PlatformNotSupportedException("PCL"); } }
        
        #endregion

		#region METHODS

        public override void Flush() { throw new PlatformNotSupportedException("PCL"); }

        public override int Read(byte[] buffer, int offset, int count) { throw new PlatformNotSupportedException("PCL"); }

        public override long Seek(long offset, SeekOrigin origin) { throw new PlatformNotSupportedException("PCL"); }

        public override void SetLength(long value) { throw new PlatformNotSupportedException("PCL"); }

        public override void Write(byte[] buffer, int offset, int count) { throw new PlatformNotSupportedException("PCL"); }

		#endregion
	}
}