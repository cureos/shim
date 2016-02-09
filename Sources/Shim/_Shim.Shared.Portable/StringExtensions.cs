/*
 *  Copyright (c) 2013-2015, Cureos AB.
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

using System.Globalization;

namespace System
{
    /// <summary>
    /// Shim complement for the <see cref="String"/> class. <see cref="String"/> instance methods that are not available in the 
    /// PCL profile are here provided as equivalent extension methods.
    /// </summary>
    public static partial class StringExtensions
    {
        /// <summary>
        /// Get the first char from the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public static char First(this string source)
        {
            return source[0];
        }
        
        /// <summary>
        /// Get the last char from the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public static char Last(this string source)
        {
            return source[source.Length - 1];
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <param name="n">The n.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public static string ToString(this string o, CultureInfo n)
        {
            return string.Format(n, "{0}", o);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <param name="n">The n.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public static string ToString(this char o, CultureInfo n)
        {
            return string.Format(n, "{0}", o);
        }
    }
}