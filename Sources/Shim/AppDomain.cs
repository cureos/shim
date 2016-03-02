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
    using System.Reflection;

    #region DELEGATES

    /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.ResolveEventHandler"]/*' />
    [Serializable]
    public delegate Assembly ResolveEventHandler(object sender, ResolveEventArgs args);

    #endregion

    /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.AppDomain"]/*' />
    public sealed class AppDomain
    {
        #region FIELDS

        private static readonly AppDomain _currentDomain;

        #endregion

        #region CONSTRUCTORS

        static AppDomain()
        {
            _currentDomain = new AppDomain();
        }

        private AppDomain()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        #endregion

        #region EVENTS

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="E:System.AppDomain.AssemblyResolve"]/*' />
        public event ResolveEventHandler AssemblyResolve;

        #endregion

        #region PROPERTIES

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.AppDomain.CurrentDomain"]/*' />
        public static AppDomain CurrentDomain
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return _currentDomain;
#endif
            }
        }

        #endregion

        #region METHODS

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.AppDomain.GetAssemblies"]/*' />
        public Assembly[] GetAssemblies()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.AppDomain.Load(System.String)"]/*' />
        public Assembly Load(string assemblyString)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}