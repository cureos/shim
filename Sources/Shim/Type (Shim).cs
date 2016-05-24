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

namespace System
{
    /// <summary>
    /// Shim complement for the <see cref="Type"/> class, providing static members that are
    /// not included in the PCL member subset of the <see cref="Type"/> class.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class Type_
    {
        #region FIELDS

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.Type.EmptyTypes"]/*' />
#if DOTNET || SILVERLIGHT
        public static readonly Type[] EmptyTypes = Type.EmptyTypes;
#else
        public static readonly Type[] EmptyTypes = new Type[0];
#endif

        #endregion
    }
}
