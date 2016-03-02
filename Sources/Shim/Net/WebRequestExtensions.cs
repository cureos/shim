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
    using System.IO;

    /// <summary>
    /// Shim complement for the <see cref="WebRequest"/> class. <see cref="WebRequest"/> instance properties and methods that are not available in the 
    /// PCL profile are here provided as equivalent extension methods (since extension properties is not available in C#).
    /// </summary>
    public static class WebRequestExtensions
    {
        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.WebRequest.GetResponse"]/*' />
        /// <param name="request">HTTP web request object on which to get response.</param>
        public static WebResponse GetResponse(this WebRequest request)
        {
#if DOTNET
            return request.GetResponse();
#elif SILVERLIGHT || NETFX_CORE
            return request.EndGetResponse(request.BeginGetResponse(null, null));
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.WebRequest.GetRequestStream"]/*' />
        /// <param name="request">HTTP web request object on which to get request stream.</param>
        public static Stream GetRequestStream(this WebRequest request)
        {
#if DOTNET
            return request.GetRequestStream();
#elif SILVERLIGHT || NETFX_CORE
            return request.EndGetRequestStream(request.BeginGetRequestStream(null, null));
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.WebRequest.ConnectionGroupName"]/*' />
        /// <param name="request">HTTP web request object on which to set connection group name.</param>
        /// <param name="groupName">Connection group name value to set.</param>
        public static void ConnectionGroupName(this WebRequest request, string groupName)
        {
#if DOTNET
            request.ConnectionGroupName = groupName;
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.WebRequest.Proxy"]/*' />
        /// <param name="request">HTTP web request object on which to set proxy.</param>
        /// <param name="proxy">Web proxy value to set.</param>
        public static void Proxy(this WebRequest request, IWebProxy proxy)
        {
#if DOTNET
            request.Proxy = proxy;
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.WebRequest.Timeout"]/*' />
        /// <param name="request">HTTP web request object on which to set timeout.</param>
        /// <param name="timeout">Timeout value to set.</param>
        public static void Timeout(this WebRequest request, int timeout)
        {
#if DOTNET
            request.Timeout = timeout;
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.Net.WebRequest.ContentLength"]/*' />
        /// <param name="request">HTTP web request object on which to set content length.</param>
        /// <param name="contentLength">Content length value to set.</param>
        public static void ContentLength(this WebRequest request, long contentLength)
        {
#if DOTNET
            request.ContentLength = contentLength;
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }
}