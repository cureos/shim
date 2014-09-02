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

using System.Threading.Tasks;

namespace System.IO
{
    public static class StreamExtensions
    {
        public static void Close(this Stream stream)
        {
#if DOTNET || WINDOWS_PHONE || WINDOWS_PHONE_APP
            stream.Close();
#else
            stream.Dispose();
#endif
        }

        public static IAsyncResult BeginWrite(this Stream stream, byte[] buffer, int offset, int count,
                                              AsyncCallback callback, object state)
        {
#if DOTNET || WINDOWS_PHONE
            return stream.BeginWrite(buffer, offset, count, callback, state);
#else
            return
                new TaskFactory().StartNew(asyncState => stream.Write(buffer, offset, count), state)
                                 .ContinueWith(task => callback(task));
#endif
        }

        public static void EndWrite(this Stream stream, IAsyncResult asyncResult)
        {
#if DOTNET || WINDOWS_PHONE
            stream.EndWrite(asyncResult);
#endif
        }

        public static IAsyncResult BeginRead(this Stream stream, byte[] buffer, int offset, int count,
                                              AsyncCallback callback, object state)
        {
#if DOTNET || WINDOWS_PHONE
            return stream.BeginRead(buffer, offset, count, callback, state);
#else
            return new TaskFactory<int>().StartNew(asyncState => stream.Read(buffer, offset, count), state)
                                         .ContinueWith(task =>
                                                           {
                                                               callback(task);
                                                               return task.Result;
                                                           });
#endif
        }

        public static int EndRead(this Stream stream, IAsyncResult asyncResult)
        {
#if DOTNET || WINDOWS_PHONE
            return stream.EndRead(asyncResult);
#else
            var task = asyncResult as Task<int>;
            return task != null ? task.Result : 0;
#endif
        }
    }
}