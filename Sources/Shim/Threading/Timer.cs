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

namespace System.Threading
{
    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.TimerCallback"]/*' />
    public delegate void TimerCallback(object state);

    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.Timer"]/*' />
    public sealed class Timer : IDisposable
    {
        #region CONSTRUCTORS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Timer.#ctor(System.Threading.TimerCallback)"]/*' />
        public Timer(TimerCallback callback)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Timer.#ctor(System.Threading.TimerCallback,System.Object,System.Int32,System.Int32)"]/*' />
        public Timer(TimerCallback callback, object state, int dueTime, int period)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion

        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Timer.Change(System.Int32,System.Int32)"]/*' />
        public bool Change(int dueTime, int period)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Timer.Dispose"]/*' />
        public void Dispose()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}