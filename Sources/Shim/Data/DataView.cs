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

using System.Collections.Generic;
using System.Linq;

namespace System.Data
{
    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.DataView"]/*' />
    public sealed class DataView
    {
        #region FIELDS

        private readonly DataTable _table;

        #endregion

        #region CONSTRUCTORS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataView.#ctor(System.Data.DataTable)"]/*' />
        public DataView(DataTable table)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            _table = table;
#endif
        }

        #endregion

        #region METHODS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataView.ToTable(System.Boolean,System.String[])"]/*' />
        public DataTable ToTable(bool distinct, params string[] columnNames)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            var table = new DataTable { Locale = _table.Locale };
            foreach (var name in columnNames)
                table.Columns.Add(name, _table.Columns.Contains(name) ? _table.Columns[name].DataType : typeof (object));

            var viewRows = new List<DataRow>();
            foreach (DataRow row in _table.Rows)
            {
                var viewRow = new DataRow(table);
                foreach (var columnName in columnNames)
                {
                    if (table.Columns.Contains(columnName))
                        viewRow[columnName] = row[columnName];
                }
                viewRows.Add(viewRow);
            }
            foreach (var row in (distinct ? viewRows.Distinct(new DataRowComparer(_table)) : viewRows))
                table.Rows.Add(row);

            return table;
#endif
        }

        #endregion

        #region INNER CLASSES

        private class DataRowComparer : IEqualityComparer<DataRow>
        {
            #region FIELDS

            private readonly DataTable _table;
 
            #endregion

            #region CONSTRUCTORS

            internal DataRowComparer(DataTable table)
            {
                _table = table;
            }

            #endregion

            #region METHODS

            public bool Equals(DataRow x, DataRow y)
            {
                foreach (DataColumn column in _table.Columns)
                {
                    var columnName = column.ColumnName;
                    if (!x[columnName].Equals(y[columnName])) return false;
                }
                return true;
            }

            public int GetHashCode(DataRow obj)
            {
                return 1;
            }
            
            #endregion
        }

        #endregion
    }
}