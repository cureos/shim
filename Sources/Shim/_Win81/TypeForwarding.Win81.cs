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

using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

// System.Collections.Concurrent
[assembly: TypeForwardedTo(typeof(ConcurrentBag<>))]
[assembly: TypeForwardedTo(typeof(ConcurrentStack<>))]
[assembly: TypeForwardedTo(typeof(ConcurrentDictionary<,>))]
[assembly: TypeForwardedTo(typeof(Partitioner<>))]

// System.ComponentModel.DataAnnotations
[assembly: TypeForwardedTo(typeof(RangeAttribute))]

// System.IO
[assembly: TypeForwardedTo(typeof(Path))]

// System.Net
[assembly: TypeForwardedTo(typeof(IWebProxy))]

// System.Runtime.InteropServices
[assembly: TypeForwardedTo(typeof(GCHandle))]
[assembly: TypeForwardedTo(typeof(GCHandleType))]
[assembly: TypeForwardedTo(typeof(GuidAttribute))]
[assembly: TypeForwardedTo(typeof(Marshal))]
[assembly: TypeForwardedTo(typeof(MarshalAsAttribute))]
[assembly: TypeForwardedTo(typeof(UnmanagedType))]

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
