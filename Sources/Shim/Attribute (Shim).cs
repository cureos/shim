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

using System.Reflection;

namespace System
{
    /// <summary>
    /// Shim complement for the <see cref="Attribute"/> class, providing members that are
    /// not included in the PCL member subset of the <see cref="Attribute"/> class.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class Attribute_
    {
        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Attribute.GetCustomAttribute(System.Reflection.MemberInfo,System.Type)"]/*' />
        /// <remarks>On Universal Windows Platform and Portable Class Libraries, <see cref="Type"/> is not a sub-class of <see cref="MemberInfo"/>, therefore the
        /// signature of this Shim method has been modified to use <see cref="Type"/> for <paramref name="element"/> instead.</remarks>
        public static Attribute GetCustomAttribute(Type element, Type attributeType)
        {
#if DOTNET || WINDOWS_PHONE || SILVERLIGHT
            return Attribute.GetCustomAttribute(element, attributeType);
#elif NETFX_CORE
            throw new PlatformNotSupportedException("NETFX_CORE");
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }
}