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

// Adapted from Mono source code,
// https://github.com/mono/mono/blob/master/mcs/class/System/System.Net.Sockets/SocketError.cs
//
// System.Net.Sockets.SocketError.cs
//
// Author:
//	Robert Jordan  <robertj@gmx.net>
//
// Copyright (C) 2005 Novell, Inc. (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System.Net.Sockets
{
    /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="T:System.Net.Sockets.SocketError"]/*' />
    public enum SocketError
    {
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.AccessDenied"]/*' />
        AccessDenied = 10013,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.AddressAlreadyInUse"]/*' />
        AddressAlreadyInUse = 10048,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.AddressFamilyNotSupported"]/*' />
        AddressFamilyNotSupported = 10047,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.AddressNotAvailable"]/*' />
        AddressNotAvailable = 10049,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.AlreadyInProgress"]/*' />
        AlreadyInProgress = 10037,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.ConnectionAborted"]/*' />
        ConnectionAborted = 10053,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.ConnectionRefused"]/*' />
        ConnectionRefused = 10061,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.ConnectionReset"]/*' />
        ConnectionReset = 10054,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.DestinationAddressRequired"]/*' />
        DestinationAddressRequired = 10039,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.Disconnecting"]/*' />
        Disconnecting = 10101,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.Fault"]/*' />
        Fault = 10014,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.HostDown"]/*' />
        HostDown = 10064,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.HostNotFound"]/*' />
        HostNotFound = 11001,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.HostUnreachable"]/*' />
        HostUnreachable = 10065,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.InProgress"]/*' />
        InProgress = 10036,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.Interrupted"]/*' />
        Interrupted = 10004,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.InvalidArgument"]/*' />
        InvalidArgument = 10022,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.IOPending"]/*' />
        IOPending = 997,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.IsConnected"]/*' />
        IsConnected = 10056,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.MessageSize"]/*' />
        MessageSize = 10040,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NetworkDown"]/*' />
        NetworkDown = 10050,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NetworkReset"]/*' />
        NetworkReset = 10052,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NetworkUnreachable"]/*' />
        NetworkUnreachable = 10051,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NoBufferSpaceAvailable"]/*' />
        NoBufferSpaceAvailable = 10055,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NoData"]/*' />
        NoData = 11004,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NoRecovery"]/*' />
        NoRecovery = 11003,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NotConnected"]/*' />
        NotConnected = 10057,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NotInitialized"]/*' />
        NotInitialized = 10093,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.NotSocket"]/*' />
        NotSocket = 10038,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.OperationAborted"]/*' />
        OperationAborted = 995,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.OperationNotSupported"]/*' />
        OperationNotSupported = 10045,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.ProcessLimit"]/*' />
        ProcessLimit = 10067,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.ProtocolFamilyNotSupported"]/*' />
        ProtocolFamilyNotSupported = 10046,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.ProtocolNotSupported"]/*' />
        ProtocolNotSupported = 10043,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.ProtocolOption"]/*' />
        ProtocolOption = 10042,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.ProtocolType"]/*' />
        ProtocolType = 10041,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.Shutdown"]/*' />
        Shutdown = 10058,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.SocketError"]/*' />
        SocketError = -1,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.SocketNotSupported"]/*' />
        SocketNotSupported = 10044,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.Success"]/*' />
        Success = 0,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.SystemNotReady"]/*' />
        SystemNotReady = 10091,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.TimedOut"]/*' />
        TimedOut = 10060,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.TooManyOpenSockets"]/*' />
        TooManyOpenSockets = 10024,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.TryAgain"]/*' />
        TryAgain = 11002,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.TypeNotFound"]/*' />
        TypeNotFound = 10109,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.VersionNotSupported"]/*' />
        VersionNotSupported = 10092,
        /// <include file='../../_Doc/System.xml' path='doc/members/member[@name="F:System.Net.Sockets.SocketError.WouldBlock"]/*' />
        WouldBlock = 10035
    }
}