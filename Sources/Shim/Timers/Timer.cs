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

namespace System.Timers
{
    using System.ComponentModel;

    /// <include file='../_Doc/System.xml' path='doc/members/member[@name="T:System.Timers.ElapsedEventHandler"]/*' />
    public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);

    /// <include file='../_Doc/System.xml' path='doc/members/member[@name="T:System.Timers.Timer"]/*' />
    public sealed class Timer : IDisposable
    {
        #region EVENTS

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="E:System.Timers.Timer.Elapsed"]/*' />
        public event ElapsedEventHandler Elapsed
        {
            add
            {
                throw new PlatformNotSupportedException("PCL");
            }
            remove
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.Timers.Timer.Enabled"]/*' />
        public bool Enabled { get; set; }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.Timers.Timer.Interval"]/*' />
        public double Interval { get; set; }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.Timers.Timer.SynchronizingObject"]/*' />
        public ISynchronizeInvoke SynchronizingObject { get; set; }

        #endregion

        #region METHODS

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.ComponentModel.Component.Dispose"]/*' />
        public void Dispose()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Timers.Timer.Start"]/*' />
        public void Start()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Timers.Timer.Stop"]/*' />
        public void Stop()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}
