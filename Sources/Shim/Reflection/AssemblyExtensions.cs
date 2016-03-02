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
    using System.Linq;

    /// <summary>
    /// Shim complement for the <see cref="Assembly"/> class. <see cref="Assembly"/> instance methods that are not available in the 
    /// PCL profile are here provided as equivalent extension methods.
    /// </summary>
    public static class AssemblyExtensions
    {
        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Reflection.Assembly.CreateInstance(System.String)"]/*' />
        /// <param name="assembly">Assembly on which the <paramref name="typeName"/> instance should be created.</param>
        public static object CreateInstance(this Assembly assembly, string typeName)
        {
#if DOTNET || SILVERLIGHT
            return assembly.CreateInstance(typeName);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Reflection.Assembly.GetTypes"]/*' />
        /// <param name="assembly">Assembly for which the array of types should be listed.</param>
        public static Type[] GetTypes(this Assembly assembly)
        {
#if DOTNET || SILVERLIGHT
            return assembly.GetTypes();
#elif NETFX_CORE
            return assembly.DefinedTypes.Select(typeInfo => typeInfo.AsType()).ToArray();
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        #endregion
    }
}