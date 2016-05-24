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
    using System.Linq;
    using System.Reflection;
    using System.Globalization;

    /// <summary>
    /// Shim complement for the <see cref="Type"/> class. <see cref="Type"/> instance methods that are not available in the 
    /// PCL profile are here provided as equivalent extension methods. <see cref="Type"/> instance properties that are not available
    /// in the PCL profile are here provided as extension methods without additional arguments (since extension properties are not supported in C#).
    /// </summary>
    public static class TypeExtensions
    {
        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Type.IsEnum"]/*' />
        public static bool IsEnum(this Type type)
        {
#if DOTNET || SILVERLIGHT
            return type.IsEnum;
#elif NETFX_CORE
            return type.GetTypeInfo().IsEnum;
#else 
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Type.IsValueType"]/*' />
        public static bool IsValueType(this Type type)
        {
#if DOTNET || SILVERLIGHT
            return type.IsValueType;
#elif NETFX_CORE
            return type.GetTypeInfo().IsValueType;
#else 
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.IsAssignableFrom(System.Type)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static bool IsAssignableFrom(this Type type, Type c)
        {
#if DOTNET || SILVERLIGHT
            return type.IsAssignableFrom(c);
#elif NETFX_CORE
            return type.GetTypeInfo().IsAssignableFrom(c.GetTypeInfo());
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.IsSubclassOf(System.Type)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static bool IsSubclassOf(this Type type, Type c)
        {
#if DOTNET || SILVERLIGHT
            return type.IsSubclassOf(c);
#elif NETFX_CORE
            return type.GetTypeInfo().IsSubclassOf(c);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.IsInstanceOfType(System.Object)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static bool IsInstanceOfType(this Type type, object o)
        {
#if DOTNET || SILVERLIGHT
            return type.IsInstanceOfType(o);
#elif NETFX_CORE
            return o.GetType() == type || o.GetType().GetTypeInfo().IsSubclassOf(type);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetConstructor(System.Type[])"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static ConstructorInfo GetConstructor(this Type type, Type[] types)
        {
#if DOTNET || SILVERLIGHT
            return type.GetConstructor(types);
#elif NETFX_CORE
            var typeInfo = type.GetTypeInfo();
            foreach (var constructorInfo in typeInfo.DeclaredConstructors)
            {
                var constructorTypes = constructorInfo.GetParameters().Select(param => param.ParameterType).ToArray();
                if (constructorTypes.Length != types.Length)
                {
                    continue;
                }
                var use = true;
                for (var i = 0; i < constructorTypes.Length; ++i)
                {
                    if (constructorTypes[i] != types[i])
                    {
                        use = false;
                        break;
                    }
                }
                if (use) return constructorInfo;
            }
            return null;
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetField(System.String)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static FieldInfo GetField(this Type type, string name)
        {
#if DOTNET || SILVERLIGHT
            return type.GetField(name);
#elif NETFX_CORE
            return type.GetRuntimeField(name);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetField(System.String,System.Reflection.BindingFlags)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static FieldInfo GetField(this Type type, string name, BindingFlags bindingAttr)
        {
#if DOTNET || SILVERLIGHT
            return type.GetField(name, bindingAttr);
#elif NETFX_CORE
            return
                type.GetRuntimeFields()
                    .Where(fi => AreBindingFlagsMatching(fi, bindingAttr))
                    .SingleOrDefault(fi => fi.Name.Equals(name));
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetField(System.String)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static PropertyInfo GetProperty(this Type type, string name)
        {
#if DOTNET || SILVERLIGHT
            return type.GetProperty(name);
#elif NETFX_CORE
            return type.GetRuntimeProperty(name);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetMethod(System.String,System.Type[])"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static MethodInfo GetMethod(this Type type, string name, Type[] types)
        {
#if DOTNET || SILVERLIGHT
            return type.GetMethod(name, types);
#elif NETFX_CORE
            var typeInfo = type.GetTypeInfo();
            foreach (var methodInfo in typeInfo.DeclaredMethods)
            {
                var methodTypes = methodInfo.GetParameters().Select(param => param.ParameterType).ToArray();
                if (methodTypes.Length != types.Length)
                {
                    continue;
                }
                var use = true;
                for (var i = 0; i < methodTypes.Length; ++i)
                {
                    if (methodTypes[i] != types[i])
                    {
                        use = false;
                        break;
                    }
                }
                if (use) return methodInfo;
            }
            return null;
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr)
        {
#if DOTNET || SILVERLIGHT
            return type.GetMethod(name, bindingAttr);
#elif NETFX_CORE
            return
                type.GetRuntimeMethods()
                    .Where(mi => AreBindingFlagsMatching(mi, bindingAttr))
                    .SingleOrDefault(mi => mi.Name.Equals(name));
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetFields(System.Reflection.BindingFlags)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static FieldInfo[] GetFields(this Type type, BindingFlags bindingAttr)
        {
#if DOTNET || SILVERLIGHT
            return type.GetFields(bindingAttr);
#elif NETFX_CORE
            return
                type.GetRuntimeFields()
                    .Where(fieldInfo => AreBindingFlagsMatching(fieldInfo, bindingAttr))
                    .ToArray();
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetMethods(System.Reflection.BindingFlags)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static MethodInfo[] GetMethods(this Type type, BindingFlags bindingAttr)
        {
#if DOTNET || SILVERLIGHT
            return type.GetMethods(bindingAttr);
#elif NETFX_CORE
            return
                type.GetRuntimeMethods()
                    .Where(methodInfo => AreBindingFlagsMatching(methodInfo, bindingAttr))
                    .ToArray();
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Globalization.CultureInfo)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static object InvokeMember(this Type type, string name, BindingFlags invokeAttr, 
            Binder binder, object target, object[] args, CultureInfo culture)
        {
#if DOTNET || WINDOWS_PHONE
            return type.InvokeMember(name, invokeAttr, binder, target, args, culture);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

#if NETFX_CORE
        private static bool AreBindingFlagsMatching(MethodInfo methodInfo, BindingFlags bindingAttr)
        {
            var publicFlag = bindingAttr.HasFlag(BindingFlags.Public);
            var nonPublicFlag = bindingAttr.HasFlag(BindingFlags.NonPublic);

            var staticFlag = bindingAttr.HasFlag(BindingFlags.Static);
            var instanceFlag = bindingAttr.HasFlag(BindingFlags.Instance);

            return ((methodInfo.IsPublic && publicFlag) || (!methodInfo.IsPublic && nonPublicFlag)) &&
                   ((methodInfo.IsStatic && staticFlag) || (!methodInfo.IsStatic && instanceFlag));
        }

        private static bool AreBindingFlagsMatching(FieldInfo fieldInfo, BindingFlags bindingAttr)
        {
            var publicFlag = bindingAttr.HasFlag(BindingFlags.Public);
            var nonPublicFlag = bindingAttr.HasFlag(BindingFlags.NonPublic);

            var staticFlag = bindingAttr.HasFlag(BindingFlags.Static);
            var instanceFlag = bindingAttr.HasFlag(BindingFlags.Instance);

            return ((fieldInfo.IsPublic && publicFlag) || (!fieldInfo.IsPublic && nonPublicFlag)) &&
                   ((fieldInfo.IsStatic && staticFlag) || (!fieldInfo.IsStatic && instanceFlag));
        }
#endif
    }
}