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
    /// Shim complement for the <see cref="WebResponse"/> class. <see cref="WebResponse"/> instance methods that are not available in the 
    /// PCL profile are here provided as equivalent extension methods.
    /// </summary>
    public static class WebResponseExtensions
    {
        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.WebResponse.Close"]/*' />
        /// <param name="webResponse">HTTP web response object to close.</param>
        public static void Close(this WebResponse webResponse)
        {
#if DOTNET || SILVERLIGHT
            webResponse.Close();
#elif NETFX_CORE
            webResponse.Dispose();
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }
}