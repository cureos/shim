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
    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.FileInfo"]/*' />
    public sealed class FileInfo
    {
        #region FIELDS

        private static readonly object locker = new object();

        private string fileName;

        #endregion

        #region CONSTRUCTORS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.#ctor(System.String)"]/*' />
        public FileInfo(string fileName)
        {
            this.fileName = fileName;
        }
        
        #endregion

        #region PROPERTIES

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileSystemInfo.Attributes"]/*' />
        public FileAttributes Attributes
        {
            get
            {
                return File.GetAttributes(this.fileName);
            }
            set
            {
                File.SetAttributes(this.fileName, value);
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileSystemInfo.FullName"]/*' />
        public string FullName
        {
            get
            {
                return this.fileName;
            }
        }


        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.Name"]/*' />
        public string Name
        {
            get
            {
                return Path.GetFileName(this.fileName);
            }
        }


        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.DirectoryName"]/*' />
        public string DirectoryName
        {
            get
            {
                return Path.GetDirectoryName(this.fileName);
            }
        }


        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.Exists"]/*' />
        public bool Exists
        {
            get
            {
                return File.Exists(this.fileName);
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.Extension"]/*' />
        public string Extension
        {
            get
            {
                return Path.GetExtension(this.fileName);
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.IO.FileInfo.Directory"]/*' />
        public DirectoryInfo Directory
        {
            get { return new DirectoryInfo(this.DirectoryName); }
        }

        #endregion

        #region METHODS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.Delete"]/*' />
        public void Delete()
        {
            File.Delete(this.fileName);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.Create"]/*' />
        public FileStream Create()
        {
            return new FileStream(this.fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.OpenRead"]/*' />
        public FileStream OpenRead()
        {
            return File.OpenRead(this.fileName);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.OpenWrite"]/*' />
        public FileStream OpenWrite()
        {
            return File.OpenWrite(this.fileName);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.FileInfo.MoveTo(System.String)"]/*' />
        public void MoveTo(string destFileName)
        {
            lock (locker)
            {
                File.Move(this.fileName, destFileName);
                this.fileName = destFileName;
            }
        }

        #endregion
    }
}