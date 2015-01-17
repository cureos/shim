/*
 *  Copyright (c) 2013-2015, Cureos AB.
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
        #region FIELDS

        private readonly DataTable _table;
        private readonly List<DataColumn> _columns;
        private readonly object _syncRoot;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a collection of data columns.
        /// </summary>
        /// <param name="table">Table that is the owner of the collection of data columns.</param>
        internal DataColumnCollection(DataTable table)
        {
            _table = table;
            _columns = new List<DataColumn>();
            _syncRoot = new object();
        }

        #endregion

        #region INDEXERS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumnCollection.Item(System.String)"]/*' />
        public DataColumn this[string name]
        {
            get { return _columns.Single(col => col.ColumnName.Equals(name)); }
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumnCollection.Item(System.Int32)"]/*' />
        public DataColumn this[int index]
        {
            get { return _columns[index]; }
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.InternalDataCollectionBase.Count"]/*' />
        public int Count
        {
            get { return _columns.Count; }
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.InternalDataCollectionBase.IsSynchronized"]/*' />
        public bool IsSynchronized
        {
            get { return true; }
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.InternalDataCollectionBase.SyncRoot"]/*' />
        public object SyncRoot
        {
            get { return _syncRoot; }
        }

        #endregion
        
        #region METHODS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumnCollection.Add(System.String,System.Type)"]/*' />
        public DataColumn Add(string columnName, Type type)
        {
            var column = new DataColumn(_table, columnName, type);
            _columns.Add(column);
            return column;
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumnCollection.Contains(System.String)"]/*' />
        public bool Contains(string name)
        {
            return _columns.Any(col => col.ColumnName.Equals(name));
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.InternalDataCollectionBase.GetEnumerator"]/*' />
        public IEnumerator GetEnumerator()
        {
            return _columns.GetEnumerator();
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.InternalDataCollectionBase.CopyTo(System.Array,System.Int32)"]/*' />
        public void CopyTo(Array ar, int index)
        {
            _columns.TypeSafeCopyTo(ar, index);
        }

        #endregion
    }
}