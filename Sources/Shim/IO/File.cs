/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of Shim.NET.
 *
 *  Shim.NET is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Shim.NET is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Shim.NET.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.IO
{
    public static class File
	{
		#region METHODS

        public static bool Exists(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void Delete(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static FileStream Create(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void Move(string sourceFileName, string destFileName)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static byte[] ReadAllBytes(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void WriteAllBytes(string path, byte[] bytes)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static FileAttributes GetAttributes(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void SetAttributes(string path, FileAttributes attributes)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static FileStream Open(string path, FileMode mode, FileAccess access)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static FileStream OpenRead(string path)
		{
            throw new PlatformNotSupportedException("PCL");
        }

		public static FileStream OpenWrite(string path)
		{
            throw new PlatformNotSupportedException("PCL");
        }

		#endregion
	}
}