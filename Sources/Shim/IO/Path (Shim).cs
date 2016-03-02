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
    /// Shim complement for the <see cref="Path"/> class, providing static members that are
    /// not included in all platform subsets of the <see cref="Path"/> class.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class Path_
    {
        #region FIELDS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.Path.PathSeparator"]/*' />
        public static readonly char PathSeparator;

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.IO.Path.DirectorySeparatorChar"]/*' />
        public static readonly char DirectorySeparatorChar;

        #endregion

        #region CONSTRUCTORS

        static Path_()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#elif __IOS__
            PathSeparator ='/';
            DirectorySeparatorChar = '/';
#else
            PathSeparator = '\\';
            DirectorySeparatorChar = '\\';
#endif
        }

        #endregion
    }
}
