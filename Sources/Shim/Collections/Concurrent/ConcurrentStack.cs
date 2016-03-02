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

    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Collections.Concurrent.ConcurrentStack`1"]/*' />
    public sealed class ConcurrentStack<T> : IEnumerable<T>, ICollection
    {
        #region FIELDS

#if !PCL
        private readonly Stack<T> stack;
#endif

        #endregion

        #region CONSTRUCTORS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentStack`1.#ctor"]/*' />
        public ConcurrentStack()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.stack = new Stack<T>();
#endif
        }

        #endregion
        
        #region PROPERTIES

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Collections.Concurrent.ConcurrentStack`1.Count"]/*' />
        public int Count
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return this.stack.Count;
#endif
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Collections.Concurrent.ConcurrentStack`1.System#Collections#ICollection#IsSynchronized"]/*' />
        bool ICollection.IsSynchronized
        {
            get
            {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
                return false;
#endif
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Collections.Concurrent.ConcurrentStack`1.System#Collections#ICollection#SyncRoot"]/*' />
        object ICollection.SyncRoot
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                throw new NotSupportedException();
#endif
            }
        }

        #endregion

        #region METHODS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentStack`1.GetEnumerator"]/*' />
        public IEnumerator<T> GetEnumerator()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return this.stack.GetEnumerator();
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentStack`1.System#Collections#IEnumerable#GetEnumerator"]/*' />
        IEnumerator IEnumerable.GetEnumerator()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return GetEnumerator();
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentStack`1.CopyTo(`0[],System.Int32)"]/*' />
        public void CopyTo(T[] array, int index)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.stack.CopyTo(array, index);
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentStack`1.System#Collections#ICollection#CopyTo(System.Array,System.Int32)"]/*' />
        void ICollection.CopyTo(Array array, int index)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.stack.TypeSafeCopyTo(array, index);
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentStack`1.ToArray"]/*' />
        public T[] ToArray()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return this.stack.ToArray();
#endif
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.ConcurrentStack`1.Push(`0)"]/*' />
        public void Push(T item)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.stack.Push(item);
#endif
        }

        #endregion
    }
}