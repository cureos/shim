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

namespace System.Net
{
    /// <summary>
    /// Shim complement for the <see cref="HttpWebRequest"/> class. <see cref="HttpWebRequest"/> instance properties that are not available in the 
    /// PCL profile are here provided as equivalent extension methods (since extension properties is not available in C#).
    /// </summary>
    static public class HttpWebRequestExtensions
    {
        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.HttpWebRequest.UserAgent"]/*' />
        /// <param name="request">HTTP web request object on which to set user agent.</param>
        /// <param name="userAgent">User agent value to set.</param>
        public static void UserAgent(this HttpWebRequest request, string userAgent)
        {
#if DOTNET
            request.UserAgent = userAgent;
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }
}