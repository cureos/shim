/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSShim.
 *
 *  CSShim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  CSShim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with CSShim. If not, see <http://www.gnu.org/licenses/>.
 */

namespace System
{
    using System.Reflection;

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
        }

        #endregion

        #region PROPERTIES

        public static AppDomain CurrentDomain
        {
            get
            {
                return _currentDomain;
            }
        }

        #endregion

        #region METHODS

        public Assembly[] GetAssemblies()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}