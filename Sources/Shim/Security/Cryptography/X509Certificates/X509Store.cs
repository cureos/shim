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

namespace System.Security.Cryptography.X509Certificates
{
    /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="T:System.Security.Cryptography.X509Certificates.X509Store"]/*' />
    public sealed class X509Store
    {
        #region CONSTRUCTORS

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Security.Cryptography.X509Certificates.X509Store.#ctor(System.Security.Cryptography.X509Certificates.StoreName,System.Security.Cryptography.X509Certificates.StoreLocation)"]/*' />
        public X509Store(StoreName storeName, StoreLocation storeLocation)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            Certificates = new X509Certificate2Collection();
#endif
        }

        #endregion

        #region PROPERTIES

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="P:System.Security.Cryptography.X509Certificates.X509Store.Certificates"]/*' />
        public X509Certificate2Collection Certificates { get; private set; }

        #endregion

        #region METHODS

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Security.Cryptography.X509Certificates.X509Store.Open(System.Security.Cryptography.X509Certificates.OpenFlags)"]/*' />
        public void Open(OpenFlags flags)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <include file='../../../_Doc/System.xml' path='doc/members/member[@name="M:System.Security.Cryptography.X509Certificates.X509Store.Close"]/*' />
        public void Close()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        #endregion
    }
}