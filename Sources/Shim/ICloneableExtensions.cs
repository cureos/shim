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

using System.Linq;
using System.Reflection;

namespace System
{
    /// <summary>
    /// Shim complement for the <see cref="ICloneable"/> interface. Runtime support for performing <see cref="ICloneable.Clone"/> when <see cref="ICloneable"/>
    /// is not explcitly implemented.
    /// </summary>
    public static class ICloneableExtensions
    {
        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.ICloneable.Clone"]/*' />
        /// <param name="thisObject">Object to clone.</param>
        public static object Clone<T>(this T thisObject)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
#if DOTNET || SILVERLIGHT
            if (typeof(T).GetInterfaces().Contains(typeof(ICloneable)))
#else
            if (typeof(T).GetTypeInfo().ImplementedInterfaces.Contains(typeof(ICloneable)))
#endif
            {
                return ((ICloneable)thisObject).Clone();
            }
            throw new ArgumentException("Cannot clone specified object", "thisObject");
#endif
        }
    }
}