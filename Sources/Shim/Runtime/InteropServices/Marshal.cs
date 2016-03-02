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

namespace System.Runtime.InteropServices
{
    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Runtime.InteropServices.Marshal"]/*' />
    public static class Marshal
    {
        #region METHODS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.Int32)"]/*' />
        public static IntPtr AllocHGlobal(int cb)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)"]/*' />
        public static void FreeHGlobal(IntPtr hglobal)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.Copy(System.IntPtr,System.Byte[],System.Int32,System.Int32)"]/*' />
        public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.Copy(System.Byte[],System.Int32,System.IntPtr,System.Int32)"]/*' />
        public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.Copy(System.Int32[],System.Int32,System.IntPtr,System.Int32)"]/*' />
        public static void Copy(short[] source, int startIndex, IntPtr destination, int length)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.Copy(System.Int16[],System.Int32,System.IntPtr,System.Int32)"]/*' />
        public static void Copy(int[] source, int startIndex, IntPtr destination, int length)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.SizeOf(System.Object)"]/*' />
        public static int SizeOf(object structure)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.SizeOf(System.Type)"]/*' />
        public static int SizeOf(Type t)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.StructureToPtr(System.Object,System.IntPtr,System.Boolean)"]/*' />
        public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.PtrToStructure(System.IntPtr,System.Type)"]/*' />
        public static object PtrToStructure(IntPtr ptr, Type structureType)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.WriteByte(System.IntPtr,System.Byte)"]/*' />
        public static void WriteByte(IntPtr ptr, byte val)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.WriteInt16(System.IntPtr,System.Int16)"]/*' />
        public static void WriteInt16(IntPtr ptr, short val)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.WriteInt32(System.IntPtr,System.Int32)"]/*' />
        public static void WriteInt32(IntPtr ptr, int val)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.InteropServices.Marshal.WriteInt32(System.IntPtr,System.Int32,System.Int32)"]/*' />
        public static void WriteInt32(IntPtr ptr, int ofs, int val)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}