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

namespace System.Collections.Generic
{
    using Xunit;

    public class ListExtensionsTests
    {
        /// <summary>
        /// Assert that List<list type=""></list>.AsReadOnly() returns sufficiently.
        /// </summary>
        [Fact]
        public void AsReadOnly_Invoke_DoesNotThrow()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var e = Record.Exception(() => list.AsReadOnly());
            Assert.Null(e);
        }
    }
}
