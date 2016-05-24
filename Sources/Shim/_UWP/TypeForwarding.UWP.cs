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
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

[assembly: TypeForwardedTo(typeof(DBNull))]

// System.Collections.Concurrent
[assembly: TypeForwardedTo(typeof(ConcurrentBag<>))]
[assembly: TypeForwardedTo(typeof(ConcurrentStack<>))]
[assembly: TypeForwardedTo(typeof(ConcurrentDictionary<,>))]
[assembly: TypeForwardedTo(typeof(Partitioner<>))]

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
[assembly: TypeForwardedTo(typeof(SearchOption))]

// System.Net
[assembly: TypeForwardedTo(typeof(EndPoint))]
[assembly: TypeForwardedTo(typeof(IPAddress))]
[assembly: TypeForwardedTo(typeof(IWebProxy))]

// System.Net.Security
[assembly: TypeForwardedTo(typeof(SslPolicyErrors))]

// System.Net.Sockets
[assembly: TypeForwardedTo(typeof(Socket))]
[assembly: TypeForwardedTo(typeof(SocketError))]
[assembly: TypeForwardedTo(typeof(SocketException))]

// System.Reflection
[assembly: TypeForwardedTo(typeof(BindingFlags))]

// System.Runtime.InteropServices
[assembly: TypeForwardedTo(typeof(GCHandle))]
[assembly: TypeForwardedTo(typeof(GCHandleType))]
[assembly: TypeForwardedTo(typeof(GuidAttribute))]
[assembly: TypeForwardedTo(typeof(Marshal))]
[assembly: TypeForwardedTo(typeof(MarshalAsAttribute))]
[assembly: TypeForwardedTo(typeof(UnmanagedType))]

// System.Security.Authentication
[assembly: TypeForwardedTo(typeof(SslProtocols))]

// System.Threading.Timer
[assembly: TypeForwardedTo(typeof(Timer))]
[assembly: TypeForwardedTo(typeof(TimerCallback))]

// System.Threading.Tasks
[assembly: TypeForwardedTo(typeof(Parallel))]
[assembly: TypeForwardedTo(typeof(ParallelLoopResult))]
[assembly: TypeForwardedTo(typeof(ParallelLoopState))]
[assembly: TypeForwardedTo(typeof(ParallelOptions))]

// System.Xml.Linq
[assembly: TypeForwardedTo(typeof(XDocument))]
