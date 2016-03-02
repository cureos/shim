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
    using System.Globalization;

    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.DataTable"]/*' />
    public sealed class DataTable
    {
        #region CONSTRUCTORS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataTable.#ctor"]/*' />
        public DataTable()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            Columns = new DataColumnCollection(this);
            Rows = new DataRowCollection(this);
            Locale = CultureInfo.CurrentCulture;
            DefaultView = new DataView(this);
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataTable.#ctor(System.String)"]/*' />
        public DataTable(string tableName)
            : this()
        {
            this.TableName = tableName ?? "";
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataTable.TableName"]/*' />
        public string TableName { get; private set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataTable.Columns"]/*' />
        public DataColumnCollection Columns { get; private set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataTable.Rows"]/*' />
        public DataRowCollection Rows { get; private set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataTable.Locale"]/*' />
        public CultureInfo Locale { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataTable.DefaultView"]/*' />
        public DataView DefaultView { get; private set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataTable.MinimumCapacity"]/*' />
        public int MinimumCapacity { get; set; }

        #endregion

        #region METHODS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataTable.Clone"]/*' />
        public DataTable Clone()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            var table = new DataTable { Locale = this.Locale };
            foreach (DataColumn column in this.Columns) table.Columns.Add(column.ColumnName, column.DataType);
            return table;
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataTable.Copy"]/*' />
        public DataTable Copy()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            var table = Clone();
            foreach (DataRow row in this.Rows) table.Rows.Add(row.ItemArray);
            return table;
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataTable.ImportRow(System.Data.DataRow)"]/*' />
        public void ImportRow(DataRow row)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            var newRow = new DataRow(this);
            foreach (DataColumn column in this.Columns)
            {
                var columnName = column.ColumnName;
                newRow[columnName] = row[columnName];
            }
            Rows.Add(newRow);
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataTable.NewRow"]/*' />
        public DataRow NewRow()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            return new DataRow(this);
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataTable.Select(System.String,System.String)"]/*' />
        public DataRow[] Select(string filterExpression, string sort)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            throw new NotImplementedException();
#endif
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataTable.Load(System.Data.IDataReader)"]/*' />
        public void Load(IDataReader reader)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            throw new NotImplementedException();
#endif
        }

        #endregion
    }
}