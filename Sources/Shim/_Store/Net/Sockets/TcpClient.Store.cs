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

using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace System.Net.Sockets
{
	public sealed class TcpClient
	{
		#region FIELDS

		private readonly NetworkStream _stream;

		#endregion

		#region CONSTRUCTORS

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

		internal TcpClient(StreamSocket socket)
		{
			if (socket == null) throw new ArgumentNullException("socket");
			_stream = new NetworkStream(socket);
		}

		#endregion

		#region PROPERTIES

		public bool NoDelay { get; set; }

		#endregion
		
		#region METHODS

        public NetworkStream GetStream()
		{
			return _stream;
		}

		public void Close()
		{
			if (_stream != null) _stream.Dispose();
		}

		#endregion
	}
}