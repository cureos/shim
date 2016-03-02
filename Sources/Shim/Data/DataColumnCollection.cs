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
    using System.Linq;

    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.DataColumnCollection"]/*' />
    public sealed class DataColumnCollection : ICollection
    {
#if !PCL
        #region FIELDS

        private readonly DataTable _table;
        private readonly List<DataColumn> _columns;
        private readonly object _syncRoot;

        #endregion
#endif

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a collection of data columns.
        /// </summary>
        /// <param name="table">Table that is the owner of the collection of data columns.</param>
        internal DataColumnCollection(DataTable table)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            _table = table;
            _columns = new List<DataColumn>();
            _syncRoot = new object();
#endif
        }

        #endregion

        #region INDEXERS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumnCollection.Item(System.String)"]/*' />
        public DataColumn this[string name]
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return _columns.Single(col => col.ColumnName.Equals(name));
#endif
            }
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumnCollection.Item(System.Int32)"]/*' />
        public DataColumn this[int index]
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return _columns[index];
#endif
            }
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.InternalDataCollectionBase.Count"]/*' />
        public int Count
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return _columns.Count;
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

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumnCollection.Add(System.String,System.Type)"]/*' />
        public DataColumn Add(string columnName, Type type)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            var column = new DataColumn(columnName, type) { Table = _table };
            _columns.Add(column);
            return column;
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumnCollection.Add(System.String)"]/*' />
        public DataColumn Add(string columnName)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return this.Add(columnName, typeof(string));
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumnCollection.Add(System.Data.DataColumn)"]/*' />
        public void Add(DataColumn column)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            column.Table = _table;
            _columns.Add(column);
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumnCollection.Remove(System.String)"]/*' />
        public void Remove(string name)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            var column = _columns.SingleOrDefault(col => col.ColumnName.Equals(name));
            if (column != null)
            {
                _columns.Remove(column);
            }
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumnCollection.Contains(System.String)"]/*' />
        public bool Contains(string name)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return _columns.Any(col => col.ColumnName.Equals(name));
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.InternalDataCollectionBase.GetEnumerator"]/*' />
        public IEnumerator GetEnumerator()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return _columns.GetEnumerator();
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.InternalDataCollectionBase.CopyTo(System.Array,System.Int32)"]/*' />
        public void CopyTo(Array ar, int index)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            _columns.TypeSafeCopyTo(ar, index);
#endif
        }

        #endregion
    }
}