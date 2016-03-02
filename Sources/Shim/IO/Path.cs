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
    /// <summary>
    /// Shim complement for the <see cref="Path"/> class, providing members that are
    /// not included in the PCL member subset of the <see cref="Path"/> class.
    /// </summary>
    public static class Path
    {
        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Path.GetTempPath"]/*' />
        public static string GetTempPath()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Path.GetTempFileName"]/*' />
        public static string GetTempFileName()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Path.GetFullPath(System.String)"]/*' />
        public static string GetFullPath(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Path.GetDirectoryName(System.String)"]/*' />
        public static string GetDirectoryName(string path)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Path.Combine(System.String[])"]/*' />
        public static string Combine(params string[] paths)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}