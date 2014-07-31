/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSShim.
 *
 *  CSShim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  CSShim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with CSShim.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Windows.Networking.Sockets;

namespace System.Net.Sockets
{
	public sealed class TcpListener
	{
		private readonly ManualResetEventSlim _event;
		private readonly IPAddress _localaddr;
		private readonly string _port;
		private StreamSocketListener _listener;
		private TcpClient _client;

		#region CONSTRUCTORS

		public TcpListener(IPAddress localaddr, int port)
		{
			_event = new ManualResetEventSlim();
			_localaddr = localaddr;
			_port = port.ToString(CultureInfo.InvariantCulture);
		}

		#endregion

		#region METHODS

		public void Start()
		{
			_client = null;

			_listener = new StreamSocketListener();
			_listener.ConnectionReceived += OnConnectionReceived;

			// Binding to specific endpoint is currently not supported.
			_event.Reset();
			Task.Run(async () => await _listener.BindServiceNameAsync(_port));
		}

		public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, object state)
		{
			return
				new TaskFactory().StartNew(new Action<object>(asyncState => _event.Wait()), state)
				                 .ContinueWith(task => callback(task));
		}

		private void OnConnectionReceived(StreamSocketListener sender, StreamSocketListenerConnectionReceivedEventArgs args)
		{
			_client = new TcpClient(args.Socket);
			_event.Set();
		}

		public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult)
		{
			_event.Reset();
			return _client;
		}

		public void Stop()
		{
			_listener.ConnectionReceived -= OnConnectionReceived;
			_listener.Dispose();
		}

		#endregion
	}
}