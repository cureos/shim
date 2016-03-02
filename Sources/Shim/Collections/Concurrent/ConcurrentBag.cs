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

namespace System.Collections.Concurrent
{
    using System.Collections.Generic;

    /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="T:System.Collections.Concurrent.ConcurrentBag`1"]/*' />
    public class ConcurrentBag<T> : List<T>
    {
        #region FIELDS

#if !PCL
        private int _peekCounter = 0;
#endif

        #endregion

        #region METHODS

        /// <remarks>
        /// Class currently inherits <see cref="List{T}"/> for convenience, and overrides this methd for safety. 
        /// Ideally <see cref="ConcurrentBag{T}"/> should be implemented independently of <see cref="List{T}"/>.
        /// </remarks>
        public new bool Remove(T item)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            throw new NotSupportedException();
#endif
        }

        /// <remarks>
        /// Class currently inherits <see cref="List{T}"/> for convenience, and overrides this methd for safety. 
        /// Ideally <see cref="ConcurrentBag{T}"/> should be implemented independently of <see cref="List{T}"/>.
        /// </remarks>
        public new bool RemoveAt(int index)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
            throw new NotSupportedException();
        }

        /// <remarks>
        /// Class currently inherits <see cref="List{T}"/> for convenience, and overrides this methd for safety. 
        /// Ideally <see cref="ConcurrentBag{T}"/> should be implemented independently of <see cref="List{T}"/>.
        /// </remarks>
        public new int RemoveAll(Predicate<T> match)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            throw new NotSupportedException();
#endif
        }

        /// <remarks>
        /// Class currently inherits <see cref="List{T}"/> for convenience, and overrides this methd for safety. 
        /// Ideally <see cref="ConcurrentBag{T}"/> should be implemented independently of <see cref="List{T}"/>.
        /// </remarks>
        public new void RemoveRange(int index, int count)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            throw new NotSupportedException();
#endif
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentBag`1.TryPeek(`0@)"]/*' />
        public bool TryPeek(out T result)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            if (_peekCounter < Count)
            {
                result = this[_peekCounter++];
                return true;
            }

            result = default(T);
            return false;
#endif
        }

        #endregion
    }
}