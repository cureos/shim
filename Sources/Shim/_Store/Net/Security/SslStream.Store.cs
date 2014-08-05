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

using System.IO;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security
{
	public delegate bool RemoteCertificateValidationCallback(
		object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);
	
	public sealed class SslStream : MemoryStream
	{
		#region FIELDS

		private readonly NetworkStream _innerStream;
		private readonly bool _leaveInnerStreamOpen;
		private readonly RemoteCertificateValidationCallback _validateServerCertificate;
		
		#endregion

		#region CONSTRUCTORS

		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback validateServerCertificate)
		{
			var tcpClientStream = innerStream as NetworkStream;
			if (tcpClientStream == null)
				throw new ArgumentException("Stream type not associated with TCP client", "innerStream");

			_innerStream = tcpClientStream;
			_leaveInnerStreamOpen = leaveInnerStreamOpen;
			_validateServerCertificate = validateServerCertificate;
		}

		public SslStream(Stream innerStream, bool leaveInnerStreamOpen) : this(innerStream, leaveInnerStreamOpen, null)
		{
		}

		public SslStream(Stream innerStream) : this(innerStream, true, null)
		{
		}

		#endregion

		#region METHODS

		public void AuthenticateAsServer(X509Certificate serverCertificate, 
			bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			throw new NotImplementedException("SSL server support is not implemented");
		}

		public void AuthenticateAsClient(string targetHost)
		{
			_innerStream.UpgradeToSsl(targetHost);
		}
		
		#endregion
	}
}