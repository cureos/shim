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
    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.IDataReader"]/*' />
    public interface IDataReader : IDisposable, IDataRecord
    {
        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.IDataReader.Depth"]/*' />
        int Depth
        {
            get;
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.IDataReader.IsClosed"]/*' />
        bool IsClosed
        {
            get;
        }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.IDataReader.RecordsAffected"]/*' />
        int RecordsAffected
        {
            get;
        }

        #endregion

        #region METHODS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataReader.Close"]/*' />
        void Close();

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataReader.GetSchemaTable"]/*' />
        DataTable GetSchemaTable();

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataReader.NextResult"]/*' />
        bool NextResult();

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataReader.Read"]/*' />
        bool Read();

        #endregion
    }
}