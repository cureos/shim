/*
 *  Copyright (c) 2013-2015, Cureos AB.
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

// ReSharper disable once CheckNamespace
namespace Shim.Reflection
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Shim replacement for the <see cref="Assembly"/> class, providing static members that are
    /// not included in the PCL member subset of the <see cref="Assembly"/> class.
    /// </summary>
    public static class Assembly
    {
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Reflection.Assembly.GetExecutingAssembly"]/*' />
#if PROFILE328
        public static System.Reflection.Assembly GetExecutingAssembly()
        {
            throw new PlatformNotSupportedException("PCL");
        }
#elif NETFX_CORE
        public static System.Reflection.Assembly GetExecutingAssembly()
        {
            // By definition, the executing assembly is the assembly from which this method is invoked.
            // The return value should thus be the assembly from which this method is called.
            // The "classic" method used to obtain this assembly, <code>Assembly.GetCallingAssembly</code> is not
            // publicly exposed in the .NET for Windows Store assembly. Therefore the method is
            // here invoked through reflection, based on a StackOverflow tip at http://stackoverflow.com/a/14754653/650012 .
            return
                (System.Reflection.Assembly)typeof(System.Reflection.Assembly)
                .GetTypeInfo().GetDeclaredMethod("GetCallingAssembly").Invoke(null, new object[0]);
        }
#else
        public static System.Reflection.Assembly GetExecutingAssembly()
        {
            // By definition, the executing assembly is the assembly from which this method is invoked.
            // The return value should thus be the assembly from which this method is called.
            return System.Reflection.Assembly.GetCallingAssembly();
        }
#endif

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Reflection.Assembly.Load(System.String)"]/*' />
        public static System.Reflection.Assembly Load(string assemblyString)
        {
#if PROFILE328
            throw new PlatformNotSupportedException("PCL");
#elif NETFX_CORE
            return System.Reflection.Assembly.Load(new AssemblyName(assemblyString));
#else
            return System.Reflection.Assembly.Load(assemblyString);
#endif
        }
    }
}
