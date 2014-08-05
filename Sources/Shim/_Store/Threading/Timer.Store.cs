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

using Windows.System.Threading;

namespace System.Threading
{
    public delegate void TimerCallback(object state);

    public class Timer
	{
		#region FIELDS

	    private readonly TimerCallback _callback;
	    private readonly object _state;
	    private ThreadPoolTimer _timer;

		#endregion

		#region CONSTRUCTORS

        public Timer(TimerCallback callback) : this(callback, null, Timeout.Infinite, Timeout.Infinite)
        {
        }

		public Timer(TimerCallback callback, object state, int dueTime, int period)
		{
			_callback = callback;
			_state = state;
			_timer = CreateThreadPoolTimer(callback, state, dueTime, period);
		}

	    #endregion

        #region METHODS

        public bool Change(int dueTime, int period)
        {
			if (_timer != null) _timer.Cancel();
	        _timer = CreateThreadPoolTimer(_callback, _state, dueTime, period);
            return _timer != null;
        }

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