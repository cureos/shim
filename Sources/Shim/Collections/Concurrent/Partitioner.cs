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

    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Collections.Concurrent.Partitioner`1"]/*' />
    public abstract class Partitioner<TSource>
    {
        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.Partitioner`1.GetPartitions(System.Int32)"]/*' />
        public abstract IList<IEnumerator<TSource>> GetPartitions(int partitionCount);

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Collections.Concurrent.Partitioner`1.SupportsDynamicPartitions"]/*' />
        public virtual bool SupportsDynamicPartitions
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

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.Partitioner`1.GetDynamicPartitions"]/*' />
        public virtual IEnumerable<TSource> GetDynamicPartitions()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            throw new NotSupportedException();
#endif
        }
    }
}
