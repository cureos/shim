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

namespace System.Threading.Tasks
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.Threading.Tasks.Parallel"]/*' />
    public static class Parallel
    {
        #region METHODS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Tasks.Parallel.For(System.Int32,System.Int32,System.Action{System.Int32})"]/*' />
        public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int> body)
        {
            for (var i = fromInclusive; i < toExclusive; ++i) body(i);
            return new ParallelLoopResult { IsCompleted = true };
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Tasks.Parallel.For(System.Int32,System.Int32,System.Action{System.Int32,System.Threading.Tasks.ParallelLoopState})"]/*' />
        public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int, ParallelLoopState> body)
        {
            var loopState = new ParallelLoopState();
            for (var i = fromInclusive; i < toExclusive; ++i)
            {
                if (loopState.ShouldExitCurrentIteration) return new ParallelLoopResult { IsCompleted = false, LowestBreakIteration = null };
                body(i, loopState);
            }
            return new ParallelLoopResult { IsCompleted = true };
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Tasks.Parallel.For(System.Int32,System.Int32,System.Threading.Tasks.ParallelOptions,System.Action{System.Int32})"]/*' />
        public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body)
        {
            for (var i = fromInclusive; i < toExclusive; ++i) body(i);
            return new ParallelLoopResult { IsCompleted = true };
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Tasks.Parallel.For``1(System.Int32,System.Int32,System.Func{``0},System.Func{System.Int32,System.Threading.Tasks.ParallelLoopState,``0,``0},System.Action{``0})"]/*' />
        public static ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, Func<TLocal> localInit,
            Func<int, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
            var loopState = new ParallelLoopState();
            for (var i = fromInclusive; i < toExclusive; ++i)
            {
                if (loopState.ShouldExitCurrentIteration) return new ParallelLoopResult { IsCompleted = false, LowestBreakIteration = null };
                localFinally(body(i, loopState, localInit()));
            }
            return new ParallelLoopResult { IsCompleted = true };
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Tasks.Parallel.For``1(System.Int32,System.Int32,System.Threading.Tasks.ParallelOptions,System.Func{``0},System.Func{System.Int32,System.Threading.Tasks.ParallelLoopState,``0,``0},System.Action{``0})"]/*' />
        public static ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, ParallelOptions parallelOptions,
            Func<TLocal> localInit, Func<int, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
        {
            var loopState = new ParallelLoopState();
            for (var i = fromInclusive; i < toExclusive; ++i)
            {
                if (loopState.ShouldExitCurrentIteration) return new ParallelLoopResult { IsCompleted = false, LowestBreakIteration = null };
                localFinally(body(i, loopState, localInit()));
            }
            return new ParallelLoopResult { IsCompleted = true };
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Tasks.Parallel.ForEach``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0})"]/*' />
        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource> body)
        {
            foreach (var item in source) body(item);
            return new ParallelLoopResult { IsCompleted = true };
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.Threading.Tasks.Parallel.ForEach``1(System.Collections.Concurrent.Partitioner{``0},System.Threading.Tasks.ParallelOptions,System.Action{``0,System.Threading.Tasks.ParallelLoopState})"]/*' />
        public static ParallelLoopResult ForEach<TSource>(
            Partitioner<TSource> source,
            ParallelOptions parallelOptions,
            Action<TSource, ParallelLoopState> body)
        {
            var loopState = new ParallelLoopState();
            
            foreach (var partition in source.GetPartitions(1))
            {
                while (partition.MoveNext())
                {
                    if (loopState.ShouldExitCurrentIteration) return new ParallelLoopResult { IsCompleted = false, LowestBreakIteration = null };
                    body(partition.Current, loopState);
                }
            }

            return new ParallelLoopResult { IsCompleted = true };
        }

        #endregion
    }
}