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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;

using Timer = System.Threading.Timer;

// System
[assembly: TypeForwardedTo(typeof(AppDomain))]
[assembly: TypeForwardedTo(typeof(ApplicationException))]
[assembly: TypeForwardedTo(typeof(Console))]
[assembly: TypeForwardedTo(typeof(Converter<,>))]
[assembly: TypeForwardedTo(typeof(DBNull))]
[assembly: TypeForwardedTo(typeof(ICloneable))]
[assembly: TypeForwardedTo(typeof(IConvertible))]
[assembly: TypeForwardedTo(typeof(NonSerializedAttribute))]
[assembly: TypeForwardedTo(typeof(NotFiniteNumberException))]
[assembly: TypeForwardedTo(typeof(ResolveEventArgs))]
[assembly: TypeForwardedTo(typeof(ResolveEventHandler))]
[assembly: TypeForwardedTo(typeof(SerializableAttribute))]

// System.Collections.Concurrent
[assembly: TypeForwardedTo(typeof(ConcurrentBag<>))]
[assembly: TypeForwardedTo(typeof(ConcurrentStack<>))]
[assembly: TypeForwardedTo(typeof(ConcurrentDictionary<,>))]
[assembly: TypeForwardedTo(typeof(Partitioner<>))]

// System.ComponentModel
[assembly: TypeForwardedTo(typeof(BrowsableAttribute))]
[assembly: TypeForwardedTo(typeof(CategoryAttribute))]
[assembly: TypeForwardedTo(typeof(DescriptionAttribute))]
[assembly: TypeForwardedTo(typeof(DisplayNameAttribute))]
[assembly: TypeForwardedTo(typeof(ISynchronizeInvoke))]

// System.ComponentModel.DataAnnotations
[assembly: TypeForwardedTo(typeof(RangeAttribute))]

// System.Data
[assembly: TypeForwardedTo(typeof(DataColumn))]
[assembly: TypeForwardedTo(typeof(DataColumnCollection))]
[assembly: TypeForwardedTo(typeof(DataRow))]
[assembly: TypeForwardedTo(typeof(DataRowCollection))]
[assembly: TypeForwardedTo(typeof(DataTable))]
[assembly: TypeForwardedTo(typeof(DataView))]
[assembly: TypeForwardedTo(typeof(DbType))]
[assembly: TypeForwardedTo(typeof(IDataReader))]
[assembly: TypeForwardedTo(typeof(IDataRecord))]

// System.Data.Common
[assembly: TypeForwardedTo(typeof(SchemaTableColumn))]
[assembly: TypeForwardedTo(typeof(SchemaTableOptionalColumn))]

// System.Diagnostics
[assembly: TypeForwardedTo(typeof(Process))]
[assembly: TypeForwardedTo(typeof(StackTrace))]
[assembly: TypeForwardedTo(typeof(Trace))]

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
[assembly: TypeForwardedTo(typeof(RemoteCertificateValidationCallback))]
[assembly: TypeForwardedTo(typeof(SslPolicyErrors))]
[assembly: TypeForwardedTo(typeof(SslStream))]

// System.Net.Sockets
[assembly: TypeForwardedTo(typeof(NetworkStream))]
[assembly: TypeForwardedTo(typeof(Socket))]
[assembly: TypeForwardedTo(typeof(SocketError))]
[assembly: TypeForwardedTo(typeof(SocketException))]
[assembly: TypeForwardedTo(typeof(TcpClient))]
[assembly: TypeForwardedTo(typeof(TcpListener))]

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

// System.Runtime.Serialization
[assembly: TypeForwardedTo(typeof(ISerializable))]
[assembly: TypeForwardedTo(typeof(OptionalFieldAttribute))]
[assembly: TypeForwardedTo(typeof(SerializationBinder))]
[assembly: TypeForwardedTo(typeof(SerializationInfo))]

// System.Runtime.Serialization.Formatters.Binary
[assembly: TypeForwardedTo(typeof(BinaryFormatter))]

// System.Security
[assembly: TypeForwardedTo(typeof(RNGCryptoServiceProvider))]

// System.Security.Authentication
[assembly: TypeForwardedTo(typeof(SslProtocols))]

// System.Security.Cryptography.X509Certificates
[assembly: TypeForwardedTo(typeof(OpenFlags))]
[assembly: TypeForwardedTo(typeof(StoreLocation))]
[assembly: TypeForwardedTo(typeof(StoreName))]
[assembly: TypeForwardedTo(typeof(X509Certificate))]
[assembly: TypeForwardedTo(typeof(X509Certificate2Collection))]
[assembly: TypeForwardedTo(typeof(X509Chain))]
[assembly: TypeForwardedTo(typeof(X509FindType))]
[assembly: TypeForwardedTo(typeof(X509Store))]

// System.Threading
[assembly: TypeForwardedTo(typeof(Thread))]
[assembly: TypeForwardedTo(typeof(ThreadAbortException))]
[assembly: TypeForwardedTo(typeof(ThreadPool))]
[assembly: TypeForwardedTo(typeof(ThreadStart))]
[assembly: TypeForwardedTo(typeof(Timer))]
[assembly: TypeForwardedTo(typeof(TimerCallback))]
[assembly: TypeForwardedTo(typeof(WaitCallback))]

// System.Threading.Tasks
[assembly: TypeForwardedTo(typeof(Parallel))]
[assembly: TypeForwardedTo(typeof(ParallelLoopResult))]
[assembly: TypeForwardedTo(typeof(ParallelLoopState))]
[assembly: TypeForwardedTo(typeof(ParallelOptions))]

// System.Timers
[assembly: TypeForwardedTo(typeof(ElapsedEventArgs))]
[assembly: TypeForwardedTo(typeof(ElapsedEventHandler))]
[assembly: TypeForwardedTo(typeof(System.Timers.Timer))]

// System.Xml.Linq
[assembly: TypeForwardedTo(typeof(XDocument))]
