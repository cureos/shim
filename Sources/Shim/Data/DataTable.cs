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
    using System.Globalization;

    public sealed class DataTable
    {
        #region CONSTRUCTORS

        public DataTable()
        {
            Columns = new DataColumnCollection(this);
            Rows = new DataRowCollection(this);
            Locale = CultureInfo.CurrentCulture;
            DefaultView = new DataView(this);
        }

        public DataTable(string tableName)
            : this()
        {
            this.TableName = tableName ?? "";
        }

        #endregion

        #region PROPERTIES

        public string TableName { get; private set; }

        public DataColumnCollection Columns { get; private set; }

        public DataRowCollection Rows { get; private set; }

        public CultureInfo Locale { get; set; }

        public DataView DefaultView { get; private set; }

        public int MinimumCapacity { get; set; }

        #endregion

        #region METHODS

        public DataTable Clone()
        {
            var table = new DataTable { Locale = this.Locale };
            foreach (DataColumn column in this.Columns) table.Columns.Add(column.ColumnName, column.DataType);
            return table;
        }

        public DataTable Copy()
        {
            var table = Clone();
            foreach (DataRow row in this.Rows) table.Rows.Add(row.ItemArray);
            return table;
        }

        public void ImportRow(DataRow row)
        {
            var newRow = new DataRow(this);
            foreach (DataColumn column in this.Columns)
            {
                var columnName = column.ColumnName;
                newRow[columnName] = row[columnName];
            }
            Rows.Add(newRow);
        }

        public DataRow NewRow()
        {
            return new DataRow(this);
        }

        public DataRow[] Select(string filterExpression, string sort)
        {
            throw new NotImplementedException();
        }

        public void Load(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}