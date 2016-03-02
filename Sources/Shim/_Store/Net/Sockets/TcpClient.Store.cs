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

using System.Globalization;
using System.Threading.Tasks;

using Windows.Networking;
using Windows.Networking.Sockets;

namespace System.Net.Sockets
{
    /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Sockets.TcpClient"]/*' />
    public sealed class TcpClient
    {
        #region FIELDS

        private readonly NetworkStream _stream;

        #endregion

        #region CONSTRUCTORS

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.#ctor(System.String,System.Int32)"]/*' />
        public TcpClient(string hostname, int port)
        {
            try
            {
                _stream = Task.Run(async () =>
                                             {
                                                 var socket = new StreamSocket();
                                                 await socket.ConnectAsync(new HostName(hostname), port.ToString(CultureInfo.InvariantCulture));
                                                 return new NetworkStream(socket);
                                             }).Result;
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }
        }

        /// <summary>
        /// Initializes a TCP client for an existing <paramref name="socket"/>.
        /// </summary>
        /// <param name="socket">Socket on which the TCP client should be based.</param>
        internal TcpClient(StreamSocket socket)
        {
            if (socket == null) throw new ArgumentNullException("socket");
            _stream = new NetworkStream(socket);
        }

        #endregion

        #region PROPERTIES

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.TcpClient.NoDelay"]/*' />
        public bool NoDelay { get; set; }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.TcpClient.Client"]/*' />
        public Socket Client { get; set; }

        #endregion
        
        #region METHODS

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.GetStream"]/*' />
        public NetworkStream GetStream()
        {
            return _stream;
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpClient.Close"]/*' />
        public void Close()
        {
            if (_stream != null) _stream.Dispose();
        }

        #endregion
    }
}