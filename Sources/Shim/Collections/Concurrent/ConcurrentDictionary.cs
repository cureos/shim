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

    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Collections.Concurrent.ConcurrentDictionary`2"]/*' />
    public sealed class ConcurrentDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        #region FIELDS

#if !PCL
        private readonly object locker = new object();
#endif

        #endregion

        #region METHODS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentDictionary`2.AddOrUpdate(`0,System.Func{`0,`1},System.Func{`0,`1,`1})"]/*' />
        public TValue AddOrUpdate(
            TKey key,
            Func<TKey, TValue> addValueFactory,
            Func<TKey, TValue, TValue> updateValueFactory)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            TValue value;
            lock (this.locker)
            {
                if (ContainsKey(key))
                {
                    value = updateValueFactory(key, this[key]);
                    this[key] = value;
                }
                else
                {
                    value = addValueFactory(key);
                    Add(key, value);
                }
            }
            return value;
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentDictionary`2.GetOrAdd(`0,System.Func{`0,`1})"]/*' />
        public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            TValue value;
            lock (this.locker)
            {
                if (ContainsKey(key))
                {
                    value = this[key];
                }
                else
                {
                    value = valueFactory(key);
                    Add(key, value);
                }
            }
            return value;
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentDictionary`2.GetOrAdd(`0,`1)"]/*' />
        public TValue GetOrAdd(TKey key, TValue value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            lock (this.locker)
            {
                if (ContainsKey(key))
                {
                    return this[key];
                }

                Add(key, value);
                return value;
            }
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentDictionary`2.TryRemove(`0,`1@)"]/*' />
        public bool TryRemove(TKey key, out TValue value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            lock (this.locker)
            {
                if (ContainsKey(key))
                {
                    value = this[key];
                    return Remove(key);
                }

                value = default(TValue);
                return false;
            }
#endif
        }

        #endregion
    }
}