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

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

// System
[assembly: TypeForwardedTo(typeof(AppDomain))]
[assembly: TypeForwardedTo(typeof(Console))]
[assembly: TypeForwardedTo(typeof(Converter<,>))]
[assembly: TypeForwardedTo(typeof(DBNull))]
[assembly: TypeForwardedTo(typeof(IConvertible))]
[assembly: TypeForwardedTo(typeof(ResolveEventArgs))]
[assembly: TypeForwardedTo(typeof(ResolveEventHandler))]

// System.Diagnostics
[assembly: TypeForwardedTo(typeof(StackTrace))]

// System.IO
[assembly: TypeForwardedTo(typeof(Directory))]
[assembly: TypeForwardedTo(typeof(DirectoryInfo))]
[assembly: TypeForwardedTo(typeof(File))]
[assembly: TypeForwardedTo(typeof(FileAccess))]
[assembly: TypeForwardedTo(typeof(FileAttributes))]
[assembly: TypeForwardedTo(typeof(FileInfo))]
[assembly: TypeForwardedTo(typeof(FileMode))]
[assembly: TypeForwardedTo(typeof(FileShare))]
[assembly: TypeForwardedTo(typeof(FileStream))]
[assembly: TypeForwardedTo(typeof(Path))]

// System.Net
[assembly: TypeForwardedTo(typeof(EndPoint))]
[assembly: TypeForwardedTo(typeof(IPAddress))]

// System.Net.Sockets
[assembly: TypeForwardedTo(typeof(Socket))]
[assembly: TypeForwardedTo(typeof(SocketError))]
[assembly: TypeForwardedTo(typeof(SocketException))]

// System.Reflection
[assembly: TypeForwardedTo(typeof(Binder))]
[assembly: TypeForwardedTo(typeof(BindingFlags))]
[assembly: TypeForwardedTo(typeof(TargetException))]

// System.Runtime.InteropServices
[assembly: TypeForwardedTo(typeof(GCHandle))]
[assembly: TypeForwardedTo(typeof(GCHandleType))]
[assembly: TypeForwardedTo(typeof(GuidAttribute))]
[assembly: TypeForwardedTo(typeof(Marshal))]
[assembly: TypeForwardedTo(typeof(MarshalAsAttribute))]
[assembly: TypeForwardedTo(typeof(UnmanagedType))]

// System.Security
[assembly: TypeForwardedTo(typeof(RNGCryptoServiceProvider))]

// System.Security.Cryptography.X509Certificates
[assembly: TypeForwardedTo(typeof(X509Certificate))]

// System.Threading
[assembly: TypeForwardedTo(typeof(Thread))]
[assembly: TypeForwardedTo(typeof(ThreadAbortException))]
[assembly: TypeForwardedTo(typeof(ThreadPool))]
[assembly: TypeForwardedTo(typeof(ThreadStart))]
[assembly: TypeForwardedTo(typeof(Timer))]
[assembly: TypeForwardedTo(typeof(TimerCallback))]
[assembly: TypeForwardedTo(typeof(WaitCallback))]
