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

using Windows.System.Threading;

namespace System.Threading
{
    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.TimerCallback"]/*' />
    public delegate void TimerCallback(object state);

    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.Timer"]/*' />
    public sealed class Timer : IDisposable
    {
        #region FIELDS

        private readonly TimerCallback _callback;
        private readonly object _state;
        private ThreadPoolTimer _timer;

        #endregion

        #region CONSTRUCTORS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Timer.#ctor(System.Threading.TimerCallback)"]/*' />
        public Timer(TimerCallback callback)
            : this(callback, null, Timeout.Infinite, Timeout.Infinite)
        {
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Timer.#ctor(System.Threading.TimerCallback,System.Object,System.Int32,System.Int32)"]/*' />
        public Timer(TimerCallback callback, object state, int dueTime, int period)
        {
            _callback = callback;
            _state = state;
            _timer = CreateThreadPoolTimer(callback, state, dueTime, period);
        }

        #endregion

        #region METHODS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Timer.Change(System.Int32,System.Int32)"]/*' />
        public bool Change(int dueTime, int period)
        {
            if (_timer != null) _timer.Cancel();
            _timer = CreateThreadPoolTimer(_callback, _state, dueTime, period);
            return _timer != null;
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Timer.Dispose"]/*' />
        public void Dispose()
        {
        }

        /// <summary>
        /// Create internal timer object.
        /// </summary>
        /// <param name="callback">Timer callback</param>
        /// <param name="state">Object state.</param>
        /// <param name="dueTime">Due time.</param>
        /// <param name="period">Period.</param>
        /// <returns>Internal timer object.</returns>
        private static ThreadPoolTimer CreateThreadPoolTimer(TimerCallback callback, object state, int dueTime, int period)
        {
            if (dueTime == Timeout.Infinite) return null;
            return period == Timeout.Infinite
                         ? ThreadPoolTimer.CreateTimer(timer => callback(state), TimeSpan.FromMilliseconds(dueTime))
                         : ThreadPoolTimer.CreatePeriodicTimer(timer => callback(state), TimeSpan.FromMilliseconds(period));
        }

        #endregion
    }
}