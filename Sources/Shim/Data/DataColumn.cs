/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSShim.
 *
 *  CSShim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  CSShim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with CSShim. If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.Data
{
    public sealed class DataColumn
    {
        #region FIELDS

        private string _caption;
        
        #endregion

        #region CONSTRUCTORS

        internal DataColumn(DataTable table, string columnName, Type dataType)
        {
            Table = table;
            ColumnName = columnName;
            DataType = dataType;
        }

        #endregion

        #region PROPERTIES

        public DataTable Table { get; private set; }

        public Type DataType { get; set; }

        public int MaxLength { get; set; }

        public string ColumnName { get; set; }

        public string Caption
        {
            get { return _caption ?? ColumnName; }
            set { _caption = value; }
        }

        #endregion
    }
}