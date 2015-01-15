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

namespace System.Runtime.InteropServices
{
    public static class Marshal
    {
        #region METHODS

        public static IntPtr AllocHGlobal(int cb)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void FreeHGlobal(IntPtr hglobal)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static int SizeOf(object structure)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static int SizeOf(Type t)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static object PtrToStructure(IntPtr ptr, Type structureType)
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion
    }
}