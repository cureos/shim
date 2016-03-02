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

namespace System.Xml.Linq
{
    /// <summary>
    /// Shim complement for the <see cref="XDocument"/> class. <see cref="XDocument"/> instance methods that are not available in the 
    /// PCL profile are here provided as equivalent extension methods.
    /// </summary>
    public static class XDocumentExtensions
    {
        /// <include file='../../_Doc/System.Xml.Linq.xml' path='doc/members/member[@name="M:System.Xml.Linq.XDocument.Save(System.String)"]/*' />
        /// <param name="self">Document object itself.</param>
        public static void Save(this XDocument self, string fileName)
        {
#if DOTNET
            self.Save(fileName);
#elif SILVERLIGHT || NETFX_CORE
            self.Save(System.IO.File.Open(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write));
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }
}