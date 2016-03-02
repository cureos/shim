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
    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.FileAttributes"]/*' />
    [Flags]
    public enum FileAttributes
    {
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.ReadOnly"]/*' />
        ReadOnly = 0x1,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Hidden"]/*' />
        Hidden = 0x2,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.System"]/*' />
        System = 0x4,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Directory"]/*' />
        Directory = 0x10,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Archive"]/*' />
        Archive = 0x20,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Device"]/*' />
        Device = 0x40,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Normal"]/*' />
        Normal = 0x00080,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Temporary"]/*' />
        Temporary = 0x00100,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.SparseFile"]/*' />
        SparseFile = 0x200,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.ReparsePoint"]/*' />
        ReparsePoint = 0x400,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Compressed"]/*' />
        Compressed = 0x800,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Offline"]/*' />
        Offline = 0x1000,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.NotContentIndexed"]/*' />
        NotContentIndexed = 0x2000,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.FileAttributes.Encrypted"]/*' />
        Encrypted = 0x4000
    }
}