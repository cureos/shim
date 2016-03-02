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

namespace System.Reflection
{
    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Reflection.BindingFlags"]/*' />
    [Flags]
    public enum BindingFlags
    {
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.Default"]/*' />
        Default = 0x00,

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.IgnoreCase"]/*' />
        IgnoreCase = 0x01,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.DeclaredOnly"]/*' />
        DeclaredOnly = 0x02,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.Instance"]/*' />
        Instance = 0x04,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.Static"]/*' />
        Static = 0x08,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.Public"]/*' />
        Public = 0x10,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.NonPublic"]/*' />
        NonPublic = 0x20,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.FlattenHierarchy"]/*' />
        FlattenHierarchy = 0x40,

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.InvokeMethod"]/*' />
        InvokeMethod = 0x0100,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.CreateInstance"]/*' />
        CreateInstance = 0x0200,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.GetField"]/*' />
        GetField = 0x0400,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.SetField"]/*' />
        SetField = 0x0800,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.GetProperty"]/*' />
        GetProperty = 0x1000,
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Reflection.BindingFlags.SetProperty"]/*' />
        SetProperty = 0x2000
    }
}