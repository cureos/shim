/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSShim.
 *
 *  CSShim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  CSShim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with CSShim.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.IO
{
    public sealed class FileInfo
    {
        #region FIELDS

        private static readonly object locker = new object();

        private string fileName;

        #endregion

        #region CONSTRUCTORS

        public FileInfo(string fileName)
        {
            this.fileName = fileName;
        }
        
        #endregion

        #region PROPERTIES

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

        public string FullName
        {
            get
            {
                return this.fileName;
            }
        }


        public string Name
        {
            get
            {
                return Path.GetFileName(this.fileName);
            }
        }


        public string DirectoryName
        {
            get
            {
                return Path.GetDirectoryName(this.fileName);
            }
        }


        public bool Exists
        {
            get
            {
                return File.Exists(this.fileName);
            }
        }

        public DirectoryInfo Directory
        {
            get { return new DirectoryInfo(this.DirectoryName); }
        }

        #endregion

        #region METHODS

        public void Delete()
        {
            File.Delete(this.fileName);
        }

        public FileStream Create()
        {
            return new FileStream(this.fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
        }

        public FileStream OpenRead()
        {
            return File.OpenRead(this.fileName);
        }

        public FileStream OpenWrite()
        {
            return File.OpenWrite(this.fileName);
        }

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