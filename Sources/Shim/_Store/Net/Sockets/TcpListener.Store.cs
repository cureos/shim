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
using System.Threading;
using System.Threading.Tasks;

using Windows.Networking.Sockets;

namespace System.Net.Sockets
{
    /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Sockets.TcpListener"]/*' />
    public sealed class TcpListener
    {
        private readonly ManualResetEventSlim _event;
        private readonly IPAddress _localaddr;
        private readonly string _port;
        private StreamSocketListener _listener;
        private TcpClient _client;

        #region CONSTRUCTORS

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpListener.#ctor(System.Net.IPAddress,System.Int32)"]/*' />
        public TcpListener(IPAddress localaddr, int port)
        {
            _event = new ManualResetEventSlim();
            _localaddr = localaddr;
            _port = port.ToString(CultureInfo.InvariantCulture);
        }

        #endregion

        #region METHODS

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpListener.Start"]/*' />
        public void Start()
        {
            _client = null;

            _listener = new StreamSocketListener();
            _listener.ConnectionReceived += OnConnectionReceived;

            // Binding to specific endpoint is currently not supported.
            _event.Reset();
            Task.Run(async () => await _listener.BindServiceNameAsync(_port));
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpListener.BeginAcceptTcpClient(System.AsyncCallback,System.Object)"]/*' />
        public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, object state)
        {
            return
                new TaskFactory().StartNew(new Action<object>(asyncState => _event.Wait()), state)
                                 .ContinueWith(task => callback(task));
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpListener.EndAcceptTcpClient(System.IAsyncResult)"]/*' />
        public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult)
        {
            _event.Reset();
            return _client;
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.TcpListener.Stop"]/*' />
        public void Stop()
        {
            _listener.ConnectionReceived -= OnConnectionReceived;
            _listener.Dispose();
        }

        /// <summary>
        /// Event handler when connection is established.
        /// </summary>
        /// <param name="sender">Listener object.</param>
        /// <param name="args">Connection received event arguments.</param>
        private void OnConnectionReceived(StreamSocketListener sender, StreamSocketListenerConnectionReceivedEventArgs args)
        {
            _client = new TcpClient(args.Socket);
            _event.Set();
        }

        #endregion
    }
}