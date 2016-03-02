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
    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.DataColumn"]/*' />
    public sealed class DataColumn
    {
        #region FIELDS

        private string _caption;
        
        #endregion

        #region CONSTRUCTORS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.DataColumn.#ctor(System.String,System.Type)"]/*' />
        public DataColumn(string columnName, Type dataType)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            ColumnName = columnName;
            DataType = dataType;
            Table = null;
            ReadOnly = false;
            DefaultValue = null;
#endif
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.Table"]/*' />
        public DataTable Table { get; internal set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.ReadOnly"]/*' />
        public bool ReadOnly { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.DataType"]/*' />
        public Type DataType { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.MaxLength"]/*' />
        public int MaxLength { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.ColumnName"]/*' />
        public string ColumnName { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.DefaultValue"]/*' />
        public Object DefaultValue { get; set; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.DataColumn.Caption"]/*' />
        public string Caption
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return _caption ?? ColumnName;
#endif
            }
            set
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                _caption = value;
#endif
            }
        }

        #endregion
    }
}