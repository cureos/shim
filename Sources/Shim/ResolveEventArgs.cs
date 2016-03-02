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
    /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.ResolveEventArgs"]/*' />
    public sealed class ResolveEventArgs : EventArgs
    {
        #region FIELDS

        private readonly string name;

        #endregion

        #region CONSTRUCTORS

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.ResolveEventArgs.#ctor(System.String)"]/*' />
        public ResolveEventArgs(string name)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.name = name;
#endif
        }

        #endregion

        #region PROPERTIES


        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.ResolveEventArgs.Name"]/*' />
        public string Name
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return this.name;
#endif
            }
        }

        #endregion
    }
}