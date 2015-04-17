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
    using System.Reflection;

    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.DataRow"]/*' />
    public sealed class DataRow
    {
        #region FIELDS

        private readonly Dictionary<DataColumn, object> _objects;

        #endregion
        
        #region CONSTRUCTORS

        /// <summary>
        /// Initializes a data row with specified cells.
        /// </summary>
        /// <param name="table">Data table that is the owner of this data row.</param>
        /// <param name="cells">Cells to be included in the data row.</param>
        internal DataRow(DataTable table, IEnumerable cells)
        {
            Table = table;
            _objects = table.Columns.Cast<DataColumn>()
                .Zip(cells.Cast<object>(), Tuple.Create)
                .ToDictionary(tuple => tuple.Item1, tuple => tuple.Item2);
        }

        /// <summary>
        /// Initializes an empty data row.
        /// </summary>
        /// <param name="table">Data table that is the owner of this data row.</param>
        internal DataRow(DataTable table)
        {
            Table = table;
            _objects = new Dictionary<DataColumn, object>();
        }

        #endregion

        #region INDEXERS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRow.Item(System.Int32)"]/*' />
        public object this[int columnIndex]
        {
            get { return _objects.ElementAt(columnIndex); }
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRow.Item(System.Data.DataColumn)"]/*' />
        public object this[DataColumn column]
        {
            get
            {
                return _objects.ContainsKey(column) ? _objects[column] : DBNull.Value;
            }
            set
            {
#if SILVERLIGHT || PCL
                if (!column.DataType.IsInstanceOfType(value))
#else
                if (!column.DataType.GetTypeInfo().IsAssignableFrom(value.GetType().GetTypeInfo()))
#endif
                    throw new InvalidCastException(String.Format("Value {0} of type {1} is not assignable to column data type {2}.",
                        value, value.GetType().Name, column.DataType.Name));
                _objects[column] = value;
            }
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRow.Item(System.String)"]/*' />
        public object this[string columnName]
        {
            get
            {
                var column = GetDataColumn(columnName);
                return this[column];
            }
            set
            {
                var column = GetDataColumn(columnName);
                this[column] = value;
            }
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRow.Table"]/*' />
        public DataTable Table { get; private set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRow.RowError"]/*' />
        public string RowError { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataRow.ItemArray"]/*' />
        public object[] ItemArray
        {
            get { return _objects.Values.ToArray(); }
        }

        #endregion

        #region METHODS

        private DataColumn GetDataColumn(string columnName)
        {
            try
            {
                return Table.Columns.Cast<DataColumn>().Single(col => col.ColumnName.Equals(columnName));
            }
            catch (InvalidOperationException e)
            {
                throw new ArgumentException("Specified column name does not exist in data table", e);
            }
        }

        #endregion
    }
}