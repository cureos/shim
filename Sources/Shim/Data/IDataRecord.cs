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
    /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="T:System.Data.IDataRecord"]/*' />
    public interface IDataRecord
    {
        #region PROPERTIES

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.IDataRecord.FieldCount"]/*' />
        int FieldCount { get; }

        #endregion

        #region INDEXERS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.IDataRecord.Item(System.Int32)"]/*' />
        object this[int i] { get; }

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="P:System.Data.IDataRecord.Item(System.String)"]/*' />
        object this[String name] { get; }

        #endregion

        #region METHODS

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetName(System.Int32)"]/*' />
        String GetName(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetDataTypeName(System.Int32)"]/*' />
        String GetDataTypeName(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetFieldType(System.Int32)"]/*' />
        Type GetFieldType(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetValue(System.Int32)"]/*' />
        Object GetValue(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetValues(System.Object[])"]/*' />
        int GetValues(object[] values);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetOrdinal(System.String)"]/*' />
        int GetOrdinal(string name);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetBoolean(System.Int32)"]/*' />
        bool GetBoolean(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetByte(System.Int32)"]/*' />
        byte GetByte(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetBytes(System.Int32,System.Int64,System.Byte[],System.Int32,System.Int32)"]/*' />
        long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetChar(System.Int32)"]/*' />
        char GetChar(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetChars(System.Int32,System.Int64,System.Char[],System.Int32,System.Int32)"]/*' />
        long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetGuid(System.Int32)"]/*' />
        Guid GetGuid(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetInt16(System.Int32)"]/*' />
        Int16 GetInt16(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetInt32(System.Int32)"]/*' />
        Int32 GetInt32(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetInt64(System.Int32)"]/*' />
        Int64 GetInt64(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetFloat(System.Int32)"]/*' />
        float GetFloat(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetDouble(System.Int32)"]/*' />
        double GetDouble(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetString(System.Int32)"]/*' />
        String GetString(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetDecimal(System.Int32)"]/*' />
        Decimal GetDecimal(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetDateTime(System.Int32)"]/*' />
        DateTime GetDateTime(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.GetData(System.Int32)"]/*' />
        IDataReader GetData(int i);

        /// <include file='../_Doc/System.Data.xml' path='doc/members/member[@name="M:System.Data.IDataRecord.IsDBNull(System.Int32)"]/*' />
        bool IsDBNull(int i);

        #endregion
    }
}