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
    using System.Collections.Generic;
    using System.Linq;

    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.DirectoryInfo"]/*' />
    public class DirectoryInfo
    {
        #region FIELDS

        private readonly string path;

        #endregion

        #region CONSTRUCTORS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.#ctor(System.String)"]/*' />
        public DirectoryInfo(string path)
        {
            this.path = path.TrimEnd(ShimPath.DirectorySeparatorChar);
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.Exists"]/*' />
        public bool Exists
        {
            get { return Directory.Exists(this.path); }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.Parent"]/*' />
        public DirectoryInfo Parent
        {
            get
            {
                var parent = Path.GetDirectoryName(this.path);
                return parent == null ? null : new DirectoryInfo(parent);
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.Name"]/*' />
        public string Name
        {
            get
            {
                var index = this.path.LastIndexOf(ShimPath.DirectorySeparatorChar);
                return index < 0 ? this.path : this.path.Substring(index + 1);
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.FullName"]/*' />
        public string FullName
        {
            get
            {
                return this.path;
            }
        }

        #endregion

        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.Create"]/*' />
        public void Create()
        {
            // TODO Is it an issue that the CreateDirectory method creates another DirectoryInfo?
            Directory.CreateDirectory(this.path);
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.GetFiles"]/*' />
        public FileInfo[] GetFiles()
        {
            return Directory.GetFiles(this.path).Select(fileName => new FileInfo(fileName)).ToArray();
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.EnumerateFiles(System.String,System.IO.SearchOption"]/*' />
        public IEnumerable<FileInfo> EnumerateFiles(String searchPattern, SearchOption searchOption)
        {
            var files = Directory.GetFiles(this.path, searchPattern).Select(f => new FileInfo(f));
            return searchOption == SearchOption.TopDirectoryOnly
                       ? files
                       : files.Concat(
                           Directory.GetDirectories(this.path)
                             .SelectMany(d => new DirectoryInfo(d).EnumerateFiles(searchPattern, searchOption)));
        }

        #endregion
    }
}