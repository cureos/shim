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

namespace System.Collections
{
    using System.Collections.Generic;
    using System.Linq;

    internal static class CollectionExtensions
    {
        internal static void TypeSafeCopyTo<T>(this IEnumerable<T> source, Array array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", index, "Must be non-negative");
            }
            if (array.Rank > 1)
            {
                throw new ArgumentException("Array is multidimensional", "array");
            }
            if (array.GetLowerBound(0) != 0)
            {
                throw new ArgumentException("Array does not have zero-based indexing", "array");
            }

            int arrayLen;
            if (index >= (arrayLen = array.GetLength(0)))
            {
                throw new ArgumentException("Index not less than array length", "index");
            }

            var sourceArray = source.ToArray();
            var sourceLen = sourceArray.Length;
            if (index + sourceLen > arrayLen)
            {
                throw new ArgumentException("Array not large enough to hold entire stack, starting at index", "array");
            }

            var typeFilteredLen = array.OfType<T>().Count();
            if (typeFilteredLen < arrayLen)
            {
                throw new ArgumentException("Array cannot be cast to underlying source type", "array");
            }

            Array.Copy(sourceArray, 0, array, index, sourceLen);
        }
    }
}