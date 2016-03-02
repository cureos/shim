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

namespace System.IO
{
    using System.Collections.Generic;
    using System.Linq;

    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.DirectoryInfo"]/*' />
    public class DirectoryInfo
    {
        #region FIELDS

#if NETFX_CORE
        private const char DirectorySeparatorChar = '\\';
#endif
        private readonly string path;

        #endregion

        #region CONSTRUCTORS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.#ctor(System.String)"]/*' />
        public DirectoryInfo(string path)
        {
#if NETFX_CORE
            this.path = path.TrimEnd(DirectorySeparatorChar);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.Exists"]/*' />
        public bool Exists
        {
            get
            {
#if NETFX_CORE
                return Directory.Exists(this.path);
#else
                throw new PlatformNotSupportedException("PCL");
#endif
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.Parent"]/*' />
        public DirectoryInfo Parent
        {
            get
            {
#if NETFX_CORE
                var parent = Path.GetDirectoryName(this.path);
                return parent == null ? null : new DirectoryInfo(parent);
#else
                throw new PlatformNotSupportedException("PCL");
#endif
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.Name"]/*' />
        public string Name
        {
            get
            {
#if NETFX_CORE
                var index = this.path.LastIndexOf(DirectorySeparatorChar);
                return index < 0 ? this.path : this.path.Substring(index + 1);
#else
                throw new PlatformNotSupportedException("PCL");
#endif
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.DirectoryInfo.FullName"]/*' />
        public string FullName
        {
            get
            {
#if NETFX_CORE
                return this.path;
#else
                throw new PlatformNotSupportedException("PCL");
#endif
            }
        }

        #endregion

        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.Create"]/*' />
        public void Create()
        {
#if NETFX_CORE
            // TODO Is it an issue that the CreateDirectory method creates another DirectoryInfo?
            Directory.CreateDirectory(this.path);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.GetFiles"]/*' />
        public FileInfo[] GetFiles()
        {
#if NETFX_CORE
            return Directory.GetFiles(this.path).Select(fileName => new FileInfo(fileName)).ToArray();
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.DirectoryInfo.EnumerateFiles(System.String,System.IO.SearchOption"]/*' />
        public IEnumerable<FileInfo> EnumerateFiles(String searchPattern, SearchOption searchOption)
        {
#if NETFX_CORE
            var files = Directory.GetFiles(this.path, searchPattern).Select(f => new FileInfo(f));
            return searchOption == SearchOption.TopDirectoryOnly
                       ? files
                       : files.Concat(
                           Directory.GetDirectories(this.path)
                             .SelectMany(d => new DirectoryInfo(d).EnumerateFiles(searchPattern, searchOption)));
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        #endregion
    }
}