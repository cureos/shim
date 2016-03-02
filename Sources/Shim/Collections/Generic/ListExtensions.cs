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

namespace System.Collections.Generic
{
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <summary>
    /// Shim complement for the <see cref="List{T}"/> class. <see cref="List{T}"/> instance methods that are not available in the 
    /// PCL profile are here provided as equivalent extension methods.
    /// </summary>
    public static class ListExtensions
    {
        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Generic.List`1.AsReadOnly"]/*' />
        /// <param name="list">List to be returned as a read-only list.</param>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this List<T> list)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#elif NETFX_CORE
            return new ReadOnlyCollection<T>(list);
#else
            return list.AsReadOnly();
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Generic.List`1.ConvertAll``1(System.Converter{`0,``0})"]/*' />
        /// <param name="list">List subject to conversion.</param>
        public static List<TOutput> ConvertAll<T, TOutput>(this List<T> list, Converter<T, TOutput> converter)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#elif DOTNET
            return list.ConvertAll(converter);
#else
            return list.Select(item => converter(item)).ToList();
#endif
        }
    }
}