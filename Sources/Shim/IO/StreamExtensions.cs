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

namespace System.IO
{
    using System.Threading.Tasks;

    /// <summary>
    /// Shim complement for the <see cref="Stream"/> class. <see cref="Stream"/> instance methods that are not available in the 
    /// PCL profile are here provided as equivalent extension methods.
    /// </summary>
    public static class StreamExtensions
    {
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Stream.Close"]/*' />
        /// <param name="stream">Stream to be closed.</param>
        public static void Close(this Stream stream)
        {
#if DOTNET || SILVERLIGHT
            stream.Close();
#elif NETFX_CORE
            stream.Dispose();
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)"]/*' />
        /// <param name="stream">Stream on which to begin writing.</param>
        public static IAsyncResult BeginWrite(this Stream stream, byte[] buffer, int offset, int count,
                                              AsyncCallback callback, object state)
        {
#if DOTNET || SILVERLIGHT
            return stream.BeginWrite(buffer, offset, count, callback, state);
#elif NETFX_CORE
            return
                new TaskFactory().StartNew(asyncState => stream.Write(buffer, offset, count), state)
                                 .ContinueWith(task => callback(task));
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Stream.EndWrite(System.IAsyncResult)"]/*' />
        /// <param name="stream">Stream on which to end writing.</param>
        public static void EndWrite(this Stream stream, IAsyncResult asyncResult)
        {
#if DOTNET || SILVERLIGHT
            stream.EndWrite(asyncResult);
#elif NETFX_CORE
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Stream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)"]/*' />
        /// <param name="stream">Stream on which to begin reading.</param>
        public static IAsyncResult BeginRead(this Stream stream, byte[] buffer, int offset, int count,
                                              AsyncCallback callback, object state)
        {
#if DOTNET || SILVERLIGHT
            return stream.BeginRead(buffer, offset, count, callback, state);
#elif NETFX_CORE
            return new TaskFactory<int>().StartNew(asyncState => stream.Read(buffer, offset, count), state)
                                         .ContinueWith(task =>
                                                           {
                                                               callback(task);
                                                               return task.Result;
                                                           });
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Stream.EndRead(System.IAsyncResult)"]/*' />
        /// <param name="stream">Stream on which to end reading.</param>
        public static int EndRead(this Stream stream, IAsyncResult asyncResult)
        {
#if DOTNET || SILVERLIGHT
            return stream.EndRead(asyncResult);
#elif NETFX_CORE
            var task = asyncResult as Task<int>;
            return task != null ? task.Result : 0;
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }
}