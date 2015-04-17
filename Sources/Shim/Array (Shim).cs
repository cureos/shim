// Accord.Core Library
// The Portable Accord.NET Framework
// https://github.com/cureos/accord
//
// Copyright © Anders Gustafsson, 2013-2014
// anders at cureos dot com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace System
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Shim complement for the <see cref="Array"/> class, providing static members that are
    /// not included in the PCL member subset of the <see cref="Array"/> class.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class Array_
    {
        #region METHODS

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Array.Sort``2(``0[],``1[])"]/*' />
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            Sort(keys, items, Comparer<TKey>.Default);
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Array.Sort``2(``0[],``1[],System.Collections.Generic.IComparer{``0})"]/*' />
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            if (items != null)
            {
                var ordered =
                    keys.Zip(items, (k, v) => new KeyValuePair<TKey, TValue>(k, v))
                        .OrderBy(kv => kv.Key, comparer)
                        .ToArray();
                lock (keys)
                {
                    Array.Copy(ordered.Select(kv => kv.Key).ToArray(), keys, ordered.Length);
                    Array.Copy(ordered.Select(kv => kv.Value).ToArray(), items, ordered.Length);
                }
            }
            else
            {
                Array.Sort(keys);
            }
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Array.Sort``2(``0[],``1[],System.Int32,System.Int32,System.Collections.Generic.IComparer{``0})"]/*' />
        public static void Sort<TKey, TValue>(
            TKey[] keys,
            TValue[] items,
            int index,
            int length,
            IComparer<TKey> comparer)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            if (items != null)
            {
                var ordered =
                    keys.Skip(index)
                        .Take(length)
                        .Zip(items.Skip(index).Take(length), (k, v) => new KeyValuePair<TKey, TValue>(k, v))
                        .OrderBy(kv => kv.Key, comparer)
                        .ToList();
                lock (keys)
                {
                    Array.Copy(ordered.Select(kv => kv.Key).ToArray(), 0, keys, index, length);
                    Array.Copy(ordered.Select(kv => kv.Value).ToArray(), 0, items, index, length);
                }
            }
            else
            {
                Array.Sort(keys, index, length, comparer);
            }
#endif
        }

        /// <include file='_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Array.ConvertAll``2(``0[],System.Converter{``0,``1})"]/*' />
        public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            if (converter == null)
            {
                throw new ArgumentNullException("converter");
            }

            var newArray = new TOutput[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                newArray[i] = converter(array[i]);
            }
            return newArray;
#endif
        }

        #endregion
    }
}