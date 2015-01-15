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
    public static class Directory
    {
        public static bool Exists(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static DirectoryInfo CreateDirectory(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static string[] GetDirectories(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static string[] GetFiles(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static string[] GetFiles(string path, string searchPattern)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void Move(string sourceDirName, string destDirName)
        {
            throw new PlatformNotSupportedException("PCL");
        }
    }
}