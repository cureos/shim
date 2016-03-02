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

using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
    /// <include file='../../../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter"]/*' />
    public sealed class BinaryFormatter
    {
        #region PROPERTIES

        /// <include file='../../../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Binder"]/*' />
        public SerializationBinder Binder
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
            set
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        #endregion

        #region METHODS

        /// <include file='../../../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Deserialize(System.IO.Stream)"]/*' />
        public object Deserialize(Stream serializationStream)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Serialize(System.IO.Stream,System.Object)"]/*' />
        public void Serialize(Stream serializationStream, object graph)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}