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
    /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.FileInfo"]/*' />
    public sealed class FileInfo
    {
        #region CONSTRUCTORS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.#ctor(System.String)"]/*' />
        public FileInfo(string fileName)
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileSystemInfo.Attributes"]/*' />
        public FileAttributes Attributes
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
            set
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileSystemInfo.FullName"]/*' />
        public string FullName
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }


        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.Name"]/*' />
        public string Name
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }


        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.DirectoryName"]/*' />
        public string DirectoryName
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }


        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.Exists"]/*' />
        public bool Exists
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.Extension"]/*' />
        public string Extension
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.Directory"]/*' />
        public DirectoryInfo Directory
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        #endregion

        #region METHODS

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.Delete"]/*' />
        public void Delete()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.Create"]/*' />
        public FileStream Create()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.OpenRead"]/*' />
        public FileStream OpenRead()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.OpenWrite"]/*' />
        public FileStream OpenWrite()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.MoveTo(System.String)"]/*' />
        public void MoveTo(string destFileName)
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion
    }
}