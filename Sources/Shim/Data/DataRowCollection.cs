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

namespace System.Data
{
    using System.Collections;
    using System.Collections.Generic;

    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.DataRowCollection"]/*' />
    public sealed class DataRowCollection : ICollection
    {
        #region FIELDS

#if !PCL
        private readonly DataTable _table;
        private readonly List<DataRow> _rows;
        private readonly object _syncRoot;
#endif

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a collection of data rows.
        /// </summary>
        /// <param name="table">Data table that owns this collection of data rows.</param>
        internal DataRowCollection(DataTable table)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            _table = table;
            _rows = new List<DataRow>();
            _syncRoot = new object();
#endif
        }

        #endregion

        #region INDEXERS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRowCollection.Item(System.Int32)"]/*' />
        public DataRow this[int index]
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return _rows[index];
#endif
            }
        }

        #endregion
        
        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRowCollection.Count"]/*' />
        public int Count
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return _rows.Count;
#endif
            }
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.InternalDataCollectionBase.IsSynchronized"]/*' />
        public bool IsSynchronized
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return true;
#endif
            }
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.InternalDataCollectionBase.SyncRoot"]/*' />
        public object SyncRoot
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return _syncRoot;
#endif
            }
        }

        #endregion
        
        #region METHODS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.Add(System.Data.DataRow)"]/*' />
        public void Add(DataRow row)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            _rows.Add(row);
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.Add(System.Object[])"]/*' />
        public DataRow Add(object[] values)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            var row = new DataRow(_table, values);
            _rows.Add(row);
            return row;
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.Remove(System.Data.DataRow)"]/*' />
        public void Remove(DataRow row)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            _rows.Remove(row);
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.IndexOf(System.Data.DataRow)"]/*' />
        public int IndexOf(DataRow row)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return _rows.IndexOf(row);
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.GetEnumerator"]/*' />
        public IEnumerator GetEnumerator()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return _rows.GetEnumerator();
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.CopyTo(System.Array,System.Int32)"]/*' />
        public void CopyTo(Array ar, int index)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            _rows.TypeSafeCopyTo(ar, index);
#endif
        }

        #endregion
    }
}