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

namespace System.Threading
{
    public delegate void TimerCallback(object state);

    public class Timer
	{
		#region CONSTRUCTORS

        public Timer(TimerCallback callback)
        {
            throw new PlatformNotSupportedException("PCL");
        }

		public Timer(TimerCallback callback, object state, int dueTime, int period)
		{
            throw new PlatformNotSupportedException("PCL");
        }

	    #endregion

        #region METHODS

        public bool Change(int dueTime, int period)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}