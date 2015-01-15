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

namespace System.Diagnostics
{
    public sealed class Process
    {
        #region FIELDS

        private static readonly Process _currentProcess;

        private IntPtr _processorAffinity;

        #endregion

        #region CONSTRUCTORS

        static Process()
        {
            _currentProcess = new Process();
        }

        public Process()
        {
            _processorAffinity = new IntPtr((1 << Environment.ProcessorCount) - 1);
        }

        #endregion

        #region PROPERTIES

        public IntPtr ProcessorAffinity {
            get
            {
                return _processorAffinity;
            }
            set
            {
                _processorAffinity = value;
            }
        }

        #endregion

        #region METHODS

        public static Process GetCurrentProcess()
        {
            return _currentProcess;
        }

        #endregion
    }
}