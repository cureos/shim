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

namespace System.Data.Common
{
    public static class SchemaTableOptionalColumn
    {
        public static readonly string ProviderSpecificDataType = "ProviderSpecificDataType";

        public static readonly string IsAutoIncrement = "IsAutoIncrement";
        public static readonly string IsHidden = "IsHidden";
        public static readonly string IsReadOnly = "IsReadOnly";
        public static readonly string IsRowVersion = "IsRowVersion";
        public static readonly string BaseServerName = "BaseServerName";
        public static readonly string BaseCatalogName = "BaseCatalogName";

        public static readonly string AutoIncrementSeed = "AutoIncrementSeed";
        public static readonly string AutoIncrementStep = "AutoIncrementStep";
        public static readonly string DefaultValue = "DefaultValue";
        public static readonly string Expression = "Expression";

        public static readonly string BaseTableNamespace = "BaseTableNamespace";
        public static readonly string BaseColumnNamespace = "BaseColumnNamespace";
        public static readonly string ColumnMapping = "ColumnMapping";
    }
}