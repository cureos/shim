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
using System.Threading.Tasks;

using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace System.Net.Sockets
{
    /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Sockets.NetworkStream"]/*' />
    public sealed class NetworkStream : Stream
    {
        #region FIELDS

        private readonly StreamSocket _socket;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default constructor is private to avoid invalid initialization of the <see cref="NetworkStream"/> class.
        /// </summary>
        private NetworkStream()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Initializes a network stream object.
        /// </summary>
        /// <param name="socket">Socket corresponding to the network stream.</param>
        internal NetworkStream(StreamSocket socket)
        {
            _socket = socket;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Attempt to upgrade stream to SSL.
        /// </summary>
        /// <param name="validationHost">Host subject to SSL upgrade.</param>
        internal void UpgradeToSsl(string validationHost)
        {
#if SSL
            const SocketProtectionLevel protectionLevel = SocketProtectionLevel.Ssl;
#else
            const SocketProtectionLevel protectionLevel = SocketProtectionLevel.Tls10;
#endif
            if (
                !Task.Run(
                    async () => await _socket.UpgradeToSslAsync(protectionLevel, new HostName(validationHost)))
                     .Wait(10000))
                throw new InvalidOperationException(
                    String.Format("Could not authenticate '{0}' as SSL server", validationHost));
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.Flush"]/*' />
        public override void Flush()
        {
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.Read(System.Byte[],System.Int32,System.Int32)"]/*' />
        public override int Read(byte[] buffer, int offset, int size)
        {
            return Task.Run(
                async () =>
                    {
                        try
                        {
                            using (var reader = new DataReader(_socket.InputStream))
                            {
                                await reader.LoadAsync((uint)size);
                                var length = Math.Min((int)reader.UnconsumedBufferLength, size);
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

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.Seek(System.Int64,System.IO.SeekOrigin)"]/*' />
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.SetLength(System.Int64)"]/*' />
        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.Write(System.Byte[],System.Int32,System.Int32)"]/*' />
        public override void Write(byte[] buffer, int offset, int size)
        {
            try
            {
                Task.Run(
                    async () =>
                        {
                            var buf = new byte[size];
                            Array.Copy(buffer, offset, buf, 0, size);
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
        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)"]/*' />
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int size,
                                                AsyncCallback callback, object state)
        {
            return new TaskFactory<int>().StartNew(asyncState => Read(buffer, offset, size), state)
                                            .ContinueWith(task =>
                                            {
                                                callback(task);
                                                return task.Result;
                                            });
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.EndRead(System.IAsyncResult)"]/*' />
        public override int EndRead(IAsyncResult asyncResult)
        {
            var task = asyncResult as Task<int>;
            return task != null ? task.Result : 0;
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)"]/*' />
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size,
                                                AsyncCallback callback, object state)
        {
            return
                new TaskFactory().StartNew(asyncState => Write(buffer, offset, size), state)
                                    .ContinueWith(task => callback(task));
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Sockets.NetworkStream.EndWrite(System.IAsyncResult)"]/*' />
        public override void EndWrite(IAsyncResult asyncResult)
        {
        }
#endif

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.Dispose(System.Boolean)"]/*' />
        protected override void Dispose(bool disposing)
        {
            _socket.Dispose();
        }

        #endregion

        #region PROPERTIES

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.CanRead"]/*' />
        public override bool CanRead
        {
            get
            {
                return true;
            }
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.CanSeek"]/*' />
        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.CanWrite"]/*' />
        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.Length"]/*' />
        public override long Length
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.Sockets.NetworkStream.Position"]/*' />
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