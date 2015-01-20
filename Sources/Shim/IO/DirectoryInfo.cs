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

namespace System.IO
{
    using System.Linq;

    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.DirectoryInfo"]/*' />
    public class DirectoryInfo
    {
        #region FIELDS

        private readonly string _path;

        #endregion

        #region CONSTRUCTORS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.#ctor(System.String)"]/*' />
        public DirectoryInfo(string path)
        {
            _path = path;
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.Exists"]/*' />
        public bool Exists
        {
            get { return Directory.Exists(_path); }
        }
        
        #endregion

        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.Create"]/*' />
        public void Create()
        {
            // TODO Is it an issue that the CreateDirectory method creates another DirectoryInfo?
            Directory.CreateDirectory(_path);
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.GetFiles"]/*' />
        public FileInfo[] GetFiles()
        {
            return Directory.GetFiles(_path).Select(fileName => new FileInfo(fileName)).ToArray();
        }

        #endregion
    }
}