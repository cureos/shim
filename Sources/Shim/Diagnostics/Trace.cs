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

namespace System.Diagnostics
{
    /// <include file='../_Doc/System.xml' path='doc/members/member[@name="T:System.Diagnostics.Trace"]/*' />
    public static class Trace
    {
        #region METHODS

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Diagnostics.Trace.Write(System.String)"]/*' />
        public static void Write(string message)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            Console.Write(message);
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Diagnostics.Trace.WriteLine(System.String)"]/*' />
        public static void WriteLine(string message)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            Console.WriteLine(message);
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Diagnostics.Trace.TraceWarning(System.String)"]/*' />
        public static void TraceWarning(string message)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            Console.WriteLine(message);
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Diagnostics.Trace.TraceInformation(System.String,System.Object[])"]/*' />
        public static void TraceInformation(string format, params object[] args)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            Console.WriteLine(format, args);
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Diagnostics.Trace.Assert(System.Boolean)"]/*' />
        public static void Assert(bool condition)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            if (!condition) throw new InvalidOperationException("Assertion condition false");
#endif
        }
        
        #endregion
    }
}