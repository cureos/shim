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

namespace System
{
#if !DOTNET && !WINDOWS_PHONE
    using System.Linq;
#endif

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
#if DOTNET || WINDOWS_PHONE
            return type.IsEnum;
#else
            return type.GetTypeInfo().IsEnum;
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Type.IsValueType"]/*' />
        public static bool IsValueType(this Type type)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsValueType;
#else
            return type.GetTypeInfo().IsValueType;
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.IsAssignableFrom(System.Type)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static bool IsAssignableFrom(this Type type, Type c)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsAssignableFrom(c);
#else
            return type.GetTypeInfo().IsAssignableFrom(c.GetTypeInfo());
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.IsSubclassOf(System.Type)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static bool IsSubclassOf(this Type type, Type c)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsSubclassOf(c);
#else
            return type.GetTypeInfo().IsSubclassOf(c);
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.IsInstanceOfType(System.Object)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static bool IsInstanceOfType(this Type type, object o)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsInstanceOfType(o);
#else
            return o.GetType() == type || o.GetType().GetTypeInfo().IsSubclassOf(type);
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetConstructor(System.Type[])"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static ConstructorInfo GetConstructor(this Type type, Type[] types)
        {
#if DOTNET || WINDOWS_PHONE
            return type.GetConstructor(types);
#else
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
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetField(System.String)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static FieldInfo GetField(this Type type, string name)
        {
#if DOTNET || WINDOWS_PHONE
            return type.GetField(name);
#else
            return type.GetRuntimeField(name);
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr)
        {
#if DOTNET || WINDOWS_PHONE
            return type.GetMethod(name, bindingAttr);
#else
            return
                type.GetRuntimeMethods()
                    .Where(mi => AreBindingFlagsMatching(mi, bindingAttr))
                    .SingleOrDefault(mi => mi.Name.Equals(name));
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Type.GetFields(System.Reflection.BindingFlags)"]/*' />
        /// <param name="type"><see cref="Type"/> object.</param>
        public static FieldInfo[] GetFields(this Type type, BindingFlags bindingAttr)
        {
#if DOTNET || WINDOWS_PHONE
            return type.GetFields(bindingAttr);
#else
            return
                type.GetRuntimeFields()
                    .Where(fieldInfo => AreBindingFlagsMatching(fieldInfo, bindingAttr))
                    .ToArray();
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

#if !DOTNET && !WINDOWS_PHONE
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