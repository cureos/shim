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
    /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.DBNull"]/*' />
    public sealed class DBNull
    {
        #region FIELDS

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="F:System.DBNull.Value"]/*' />
        public static readonly DBNull Value;

        #endregion

        #region CONSTRUCTORS

        static DBNull()
        {
            Value = new DBNull();
        }

        private DBNull()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        #endregion
    }
}