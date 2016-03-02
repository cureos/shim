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

namespace System.Net.Sockets
{
    /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Sockets.TcpClient"]/*' />
    public sealed class TcpClient
    {
        #region CONSTRUCTORS

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.#ctor(System.String,System.Int32)"]/*' />
        public TcpClient(string hostname, int port)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion

        #region PROPERTIES

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.TcpClient.NoDelay"]/*' />
        public bool NoDelay
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

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.TcpClient.Client"]/*' />
        public Socket Client
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

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.GetStream"]/*' />
        public NetworkStream GetStream()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.Close"]/*' />
        public void Close()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}