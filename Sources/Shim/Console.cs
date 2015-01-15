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

namespace System
{
    using System.IO;

    public static class Console
    {
        #region FIELDS

        private static readonly TextWriter _error;
        private static readonly TextWriter _out;

        #endregion

        #region CONSTRUCTORS

        static Console()
        {
            _error = new StringWriter();
            _out = new StringWriter();
        }

        #endregion

        #region PROPERTIES

        public static TextWriter Error
        {
            get
            {
                return _error;
            }
        }

        public static TextWriter Out
        {
            get
            {
                return _out;
            }
        }

        #endregion

        #region METHODS

        public static void Write(char value)
        {
            _out.Write(value);
        }

        public static void Write(string value)
        {
            _out.Write(value);
        }

        public static void Write(int value)
        {
            _out.Write(value);
        }

        public static void WriteLine()
        {
            _out.WriteLine();
        }

        public static void WriteLine(char value)
        {
            _out.WriteLine(value);
        }

        public static void WriteLine(string format, params object[] arg)
        {
            _out.WriteLine(format, arg);
        }

        #endregion
    }
}