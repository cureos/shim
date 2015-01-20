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

    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.DataRowCollection"]/*' />
    public sealed class DataRowCollection : ICollection
    {
        #region FIELDS

        private readonly DataTable _table;
        private readonly List<DataRow> _rows;
        private readonly object _syncRoot;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a collection of data rows.
        /// </summary>
        /// <param name="table">Data table that owns this collection of data rows.</param>
        internal DataRowCollection(DataTable table)
        {
            _table = table;
            _rows = new List<DataRow>();
            _syncRoot = new object();
        }

        #endregion

        #region INDEXERS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRowCollection.Item(System.Int32)"]/*' />
        public DataRow this[int index]
        {
            get { return _rows[index]; }
        }

        #endregion
        
        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRowCollection.Count"]/*' />
        public int Count
        {
            get { return _rows.Count; }
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

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.Add(System.Data.DataRow)"]/*' />
        public void Add(DataRow row)
        {
            _rows.Add(row);
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.Add(System.Object[])"]/*' />
        public DataRow Add(object[] values)
        {
            var row = new DataRow(_table, values);
            _rows.Add(row);
            return row;
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.Remove(System.Data.DataRow)"]/*' />
        public void Remove(DataRow row)
        {
            _rows.Remove(row);
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.IndexOf(System.Data.DataRow)"]/*' />
        public int IndexOf(DataRow row)
        {
            return _rows.IndexOf(row);
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.GetEnumerator"]/*' />
        public IEnumerator GetEnumerator()
        {
            return _rows.GetEnumerator();
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataRowCollection.CopyTo(System.Array,System.Int32)"]/*' />
        public void CopyTo(Array ar, int index)
        {
            _rows.TypeSafeCopyTo(ar, index);
        }

        #endregion
    }
}