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
    using System.Threading.Tasks;

    #region DELEGATES

    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.ThreadStart"]/*' />
    public delegate void ThreadStart();

    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.ParameterizedThreadStart"]/*' />
    public delegate void ParameterizedThreadStart(object obj);

    #endregion 

    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.Thread"]/*' />
    public sealed class Thread
    {
        #region FIELDS

        private readonly ThreadStart start;
        private readonly ParameterizedThreadStart parameterizedStart;
        private Task task;

        #endregion

        #region CONSTRUCTORS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Thread.#ctor(System.Threading.ThreadStart)"]/*' />
        public Thread(ThreadStart start)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.start = start;
            this.parameterizedStart = null;
            this.task = null;
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Thread.#ctor(System.Threading.ParameterizedThreadStart)"]/*' />
        public Thread(ParameterizedThreadStart start)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.start = null;
            this.parameterizedStart = start;
            this.task = null;
#endif
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Threading.Thread.CurrentThread"]/*' />
        public static Thread CurrentThread
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Threading.Thread.Name"]/*' />
        public string Name { get; set; }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Threading.Thread.IsBackground"]/*' />
        public bool IsBackground { get; set; }

        #endregion

        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Thread.Start"]/*' />
        public void Start()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            if (this.start == null) throw new InvalidOperationException("Parameter-less action not defined for this thread instance.");
            this.task = Task.Run(new Action(this.start));
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Thread.Start(System.Object)"]/*' />
        public void Start(object parameter)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            if (this.parameterizedStart == null) throw new InvalidOperationException("Parameterized action not defined for this thread instance.");
            this.task = Task.Run(() => this.parameterizedStart(parameter));
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Thread.Join"]/*' />
        public void Join()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Thread.Join(System.Int32)"]/*' />
        public bool Join(int millisecondsTimeout)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Thread.Abort"]/*' />
        public void Abort()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Thread.Sleep(System.Int32)"]/*' />
        public static void Sleep(int millisecondsTimeout)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            new ManualResetEvent(false).WaitOne(millisecondsTimeout);
#endif
        }

        #endregion
    }
}