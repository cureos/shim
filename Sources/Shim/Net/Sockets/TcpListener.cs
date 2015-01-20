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
    /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Sockets.TcpListener"]/*' />
    public sealed class TcpListener
    {
        #region CONSTRUCTORS

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.#ctor(System.Net.IPAddress,System.Int32)"]/*' />
        public TcpListener(IPAddress localaddr, int port)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion

        #region METHODS

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.Start"]/*' />
        public void Start()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.BeginAcceptTcpClient(System.AsyncCallback,System.Object)"]/*' />
        public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, object state)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.EndAcceptTcpClient(System.IAsyncResult)"]/*' />
        public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.Stop"]/*' />
        public void Stop()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}