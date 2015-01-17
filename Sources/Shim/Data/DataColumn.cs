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
    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.DataColumn"]/*' />
    public sealed class DataColumn
    {
        #region FIELDS

        private string _caption;
        
        #endregion

        #region CONSTRUCTORS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumn.#ctor(System.String,System.Type)"]/*' />
        /// <param name="table"><see cref="DataTable"/> in which the column resides.</param>
        internal DataColumn(DataTable table, string columnName, Type dataType)
        {
            Table = table;
            ColumnName = columnName;
            ReadOnly = false;
            DataType = dataType;
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.Table"]/*' />
        public DataTable Table { get; private set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.ReadOnly"]/*' />
        public bool ReadOnly { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.DataType"]/*' />
        public Type DataType { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.MaxLength"]/*' />
        public int MaxLength { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.ColumnName"]/*' />
        public string ColumnName { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.Caption"]/*' />
        public string Caption
        {
            get { return _caption ?? ColumnName; }
            set { _caption = value; }
        }

        #endregion
    }
}