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
    using System.Collections.Generic;

    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.File"]/*' />
    public static class File
    {
        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Exists(System.String)"]/*' />
        public static bool Exists(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Delete(System.String)"]/*' />
        public static void Delete(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Create(System.String)"]/*' />
        public static FileStream Create(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.CreateText(System.String)"]/*' />
        public static StreamWriter CreateText(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.AppendText(System.String)"]/*' />
        public static StreamWriter AppendText(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.OpenText(System.String)"]/*' />
        public static StreamReader OpenText(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Move(System.String,System.String)"]/*' />
        public static void Move(string sourceFileName, string destFileName)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.ReadAllBytes(System.String)"]/*' />
        public static byte[] ReadAllBytes(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.ReadAllLines(System.String)"]/*' />
        public static string[] ReadAllLines(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.ReadAllText(System.String)"]/*' />
        public static string ReadAllText(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.ReadLines(System.String)"]/*' />
        public static IEnumerable<string> ReadLines(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.WriteAllBytes(System.String,System.Byte[])"]/*' />
        public static void WriteAllBytes(string path, byte[] bytes)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.WriteAllLines(System.String,System.String[])"]/*' />
        public static void WriteAllLines(string path, string[] contents)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.WriteAllLines(System.String,System.Collections.Generic.IEnumerable{System.String})"]/*' />
        public static void WriteAllLines(string path, IEnumerable<string> contents)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.WriteAllText(System.String,System.String)"]/*' />
        public static void WriteAllText(string path, string contents)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.AppendAllLines(System.String,System.Collections.Generic.IEnumerable{System.String})"]/*' />
        public static void AppendAllLines(string path, IEnumerable<string> contents)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.AppendAllText(System.String,System.String)"]/*' />
        public static void AppendAllText(string path, string contents)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.GetAttributes(System.String)"]/*' />
        public static FileAttributes GetAttributes(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.SetAttributes(System.String,System.IO.FileAttributes)"]/*' />
        public static void SetAttributes(string path, FileAttributes fileAttributes)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Open(System.String,System.IO.FileMode)"]/*' />
        public static FileStream Open(string path, FileMode mode)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Open(System.String,System.IO.FileMode,System.IO.FileAccess)"]/*' />
        public static FileStream Open(string path, FileMode mode, FileAccess access)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Open(System.String,System.IO.FileMode,System.IO.FileAccess,System.IO.FileShare)"]/*' />
        public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.OpenRead(System.String)"]/*' />
        public static FileStream OpenRead(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.OpenWrite(System.String)"]/*' />
        public static FileStream OpenWrite(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}