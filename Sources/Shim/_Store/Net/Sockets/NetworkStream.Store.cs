/*
 *  Copyright (c) 2013-2014, Cureos AB.
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

namespace System.Net.Sockets
{
    using System.IO;
    using System.Threading.Tasks;

    using global::Windows.Networking;
    using global::Windows.Networking.Sockets;
    using global::Windows.Storage.Streams;

    public sealed class NetworkStream : Stream
    {
        #region FIELDS

        private readonly StreamSocket _socket;

        #endregion

        #region CONSTRUCTORS

        private NetworkStream()
        {
            throw new NotSupportedException();
        }

        internal NetworkStream(StreamSocket socket)
        {
            _socket = socket;
        }

        #endregion

        #region METHODS

        internal void UpgradeToSsl(string validationHost)
        {
            if (
                !Task.Run(
                    async () => await _socket.UpgradeToSslAsync(SocketProtectionLevel.Ssl, new HostName(validationHost)))
                     .Wait(10000))
                throw new InvalidOperationException(
                    String.Format("Could not authenticate '{0}' as SSL server", validationHost));
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return Task.Run(
                async () =>
                    {
                        try
                        {
                            using (var reader = new DataReader(_socket.InputStream))
                            {
                                await reader.LoadAsync((uint)count);
                                var length = Math.Min((int)reader.UnconsumedBufferLength, count);
                                var buf = new byte[length];
                                reader.ReadBytes(buf);
                                reader.DetachStream();
                                Array.Copy(buf, 0, buffer, offset, length);
                                return length;
                            }
                        }
                        catch
                        {
                            return 0;
                        }
                    }).Result;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                Task.Run(
                    async () =>
                        {
                            var buf = new byte[count];
                            Array.Copy(buffer, offset, buf, 0, count);
                            using (var writer = new DataWriter(_socket.OutputStream))
                            {
                                writer.WriteBytes(buf);
                                await writer.StoreAsync();
                                writer.DetachStream();
                            }
                        }).Wait();
            }
            catch (Exception e)
            {
                throw new IOException("Socket write failure.", e.InnerException ?? e);
            }
        }

#if SILVERLIGHT
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count,
												AsyncCallback callback, object state)
		{
			return new TaskFactory<int>().StartNew(asyncState => Read(buffer, offset, count), state)
											.ContinueWith(task =>
											{
												callback(task);
												return task.Result;
											});
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			var task = asyncResult as Task<int>;
			return task != null ? task.Result : 0;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count,
												AsyncCallback callback, object state)
		{
			return
				new TaskFactory().StartNew(asyncState => Write(buffer, offset, count), state)
									.ContinueWith(task => callback(task));
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}
#endif

        protected override void Dispose(bool disposing)
        {
            _socket.Dispose();
        }

        #endregion

        #region PROPERTIES

        public override bool CanRead
        {
            get
            {
                return true;
            }
        }

        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        public override long Length
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        public override long Position
        {
            get
            {
                throw new NotSupportedException();
            }
            set
            {
                throw new NotSupportedException();
            }
        }

        #endregion
    }
}