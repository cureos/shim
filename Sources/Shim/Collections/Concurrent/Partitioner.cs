// ==++==
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// Partitioner.cs
//
// <OWNER>[....]</OWNER>
//
// Represents a particular way of splitting a collection into multiple partitions.
//
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

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
            get { return false; }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Collections.Concurrent.Partitioner`1.GetDynamicPartitions"]/*' />
        public virtual IEnumerable<TSource> GetDynamicPartitions()
        {
            throw new NotSupportedException();
        }
    }
}
