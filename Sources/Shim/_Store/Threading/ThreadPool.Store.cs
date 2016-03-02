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

using Windows.Foundation;

namespace System.Threading
{
    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.WaitCallback"]/*' />
    public delegate void WaitCallback(object state);

    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.ThreadPool"]/*' />
    public static class ThreadPool
    {
        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.ThreadPool.QueueUserWorkItem(System.Threading.WaitCallback)"]/*' />
        public static bool QueueUserWorkItem(WaitCallback callBack)
        {
            return QueueUserWorkItem(callBack, null);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.ThreadPool.QueueUserWorkItem(System.Threading.WaitCallback,System.Object)"]/*' />
        public static bool QueueUserWorkItem(WaitCallback callBack, object state)
         {
             var workItem = global::Windows.System.Threading.ThreadPool.RunAsync(source => callBack(state));
             return workItem.Status != AsyncStatus.Error;
         }
    }
}