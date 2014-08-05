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
    public sealed class FileInfo
    {
        #region CONSTRUCTORS

        public FileInfo(string fileName)
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion

        #region PROPERTIES

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

        public string FullName
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }


        public string Name
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }


        public string DirectoryName
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }


        public bool Exists
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        public DirectoryInfo Directory
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        #endregion

        #region METHODS

        public void Delete()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public FileStream Create()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public FileStream OpenRead()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public FileStream OpenWrite()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public void MoveTo(string destFileName)
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion
    }
}