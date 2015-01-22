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

namespace System.Net.Sockets
{
    /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Sockets.SocketException"]/*' />
    public class SocketException : Exception
    {
        #region CONSTRUCTORS

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.SocketException.#ctor(System.Int32)"]/*' />
        public SocketException(int errorCode)
        {
            ErrorCode = errorCode;
        }

        // TODO Check in fo-dicom where this constructor originates from?
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.SocketException.#ctor(System.String,System.Object[])"]/*' />
        public SocketException(string format, params object[] args)
            : base(String.Format(format, args))
        {
        }

        #endregion

        #region PROPERTIES

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.SocketException.ErrorCode"]/*' />
        public int ErrorCode { get; private set; }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.SocketException.SocketErrorCode"]/*' />
        public SocketError SocketErrorCode
        {
            get { return (SocketError)ErrorCode; }
        }

        #endregion
    }
}