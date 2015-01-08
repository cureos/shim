/*
 *  Copyright (c) 2013-2015, Cureos AB.
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
    public interface IDataRecord
    {
        int FieldCount { get; }

        object this[int i] { get; }

        object this[String name] { get; }

        String GetName(int i);

        String GetDataTypeName(int i);

        Type GetFieldType(int i);

        Object GetValue(int i);

        int GetValues(object[] values);

        int GetOrdinal(string name);

        bool GetBoolean(int i);

        byte GetByte(int i);

        long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length);

        char GetChar(int i);

        long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length);

        Guid GetGuid(int i);

        Int16 GetInt16(int i);

        Int32 GetInt32(int i);

        Int64 GetInt64(int i);

        float GetFloat(int i);

        double GetDouble(int i);

        String GetString(int i);

        Decimal GetDecimal(int i);

        DateTime GetDateTime(int i);

        IDataReader GetData(int i);

        bool IsDBNull(int i);
    }
}