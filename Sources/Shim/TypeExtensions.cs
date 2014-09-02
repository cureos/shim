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
#if !DOTNET && !WINDOWS_PHONE
    using System.Linq;
#endif

    using System.Reflection;
    using System.Globalization;

    public static class TypeExtensions
    {
        public static bool IsEnum(this Type type)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsEnum;
#else
            return type.GetTypeInfo().IsEnum;
#endif
        }

        public static bool IsValueType(this Type type)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsValueType;
#else
            return type.GetTypeInfo().IsValueType;
#endif
        }

        public static bool IsAssignableFrom(this Type type, Type c)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsAssignableFrom(c);
#else
            return type.GetTypeInfo().IsAssignableFrom(c.GetTypeInfo());
#endif
        }

        public static bool IsSubclassOf(this Type type, Type c)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsSubclassOf(c);
#else
            return type.GetTypeInfo().IsSubclassOf(c);
#endif
        }

        public static bool IsInstanceOfType(this Type type, object o)
        {
#if DOTNET || WINDOWS_PHONE
            return type.IsInstanceOfType(o);
#else
            return o.GetType() == type || o.GetType().GetTypeInfo().IsSubclassOf(type);
#endif
        }

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