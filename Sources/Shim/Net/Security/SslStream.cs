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

namespace System.Net.Security
{
    using System.IO;
    using System.Security.Authentication;
    using System.Security.Cryptography.X509Certificates;

    /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Security.RemoteCertificateValidationCallback"]/*' />
    public delegate bool RemoteCertificateValidationCallback(
        object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);

    /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Security.SslStream"]/*' />
    public sealed class SslStream : MemoryStream
    {
        #region CONSTRUCTORS

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Security.SslStream.#ctor(System.IO.Stream,System.Boolean,System.Net.Security.RemoteCertificateValidationCallback)"]/*' />
        public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Security.SslStream.#ctor(System.IO.Stream,System.Boolean)"]/*' />
        public SslStream(Stream innerStream, bool leaveInnerStreamOpen)
            : this(innerStream, leaveInnerStreamOpen, null)
        {
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Security.SslStream.#ctor(System.IO.Stream)"]/*' />
        public SslStream(Stream innerStream)
            : this(innerStream, true, null)
        {
        }

        #endregion

        #region METHODS

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Security.SslStream.AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate,System.Boolean,System.Security.Authentication.SslProtocols,System.Boolean)"]/*' />
        public void AuthenticateAsServer(X509Certificate serverCertificate, 
            bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="M:System.Net.Security.SslStream.AuthenticateAsClient(System.String)"]/*' />
        public void AuthenticateAsClient(string targetHost)
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion
    }
}