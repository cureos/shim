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

namespace System.IO
{
    public static class StreamExtensions
    {
        public static void Close(this Stream stream)
        {
            stream.Dispose();
        }

        public static IAsyncResult BeginWrite(this Stream stream, byte[] buffer, int offset, int count,
                                              AsyncCallback callback, object state)
        {
            return stream.BeginWrite(buffer, offset, count, callback, state);
        }

        public static void EndWrite(this Stream stream, IAsyncResult asyncResult)
        {
            stream.EndWrite(asyncResult);
        }

		public static IAsyncResult BeginRead(this Stream stream, byte[] buffer, int offset, int count,
											  AsyncCallback callback, object state)
		{
		    return stream.BeginRead(buffer, offset, count, callback, state);
		}

		public static int EndRead(this Stream stream, IAsyncResult asyncResult)
		{
		    return stream.EndRead(asyncResult);
		}
	}
}