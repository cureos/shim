/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSShim.
 *
 *  CSShim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  CSShim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with CSShim. If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.IO
{
    using System.Linq;

    public class DirectoryInfo
    {
        #region FIELDS

        private readonly string _path;

        #endregion

        #region CONSTRUCTORS

        public DirectoryInfo(string path)
        {
            _path = path;
        }

        #endregion

        #region PROPERTIES

        public bool Exists
        {
            get { return Directory.Exists(_path); }
        }
        
        #endregion

        #region METHODS

        public void Create()
        {
            // TODO Is it an issue that the CreateDirectory method creates another DirectoryInfo?
            Directory.CreateDirectory(_path);
        }

        public FileInfo[] GetFiles()
        {
            return Directory.GetFiles(_path).Select(fileName => new FileInfo(fileName)).ToArray();
        }

        #endregion
    }
}