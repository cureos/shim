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

namespace System.ComponentModel.DataAnnotations
{
    /// <include file='../../_Doc/System.ComponentModel.DataAnnotations.xml' path='doc/members/member[@name="T:System.ComponentModel.DataAnnotations.RangeAttribute"]/*' />
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class RangeAttribute : Attribute
    {
        #region FIELDS

#if !PCL
        private readonly object minimum;
        private readonly object maximum;
#endif

        #endregion

        #region CONSTRUCTORS

        /// <include file='../../_Doc/System.ComponentModel.DataAnnotations.xml' path='doc/members/member[@name="M:System.ComponentModel.DataAnnotations.RangeAttribute.#ctor(System.Double,System.Double)"]/*' />
        public RangeAttribute(double minimum, double maximum)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.minimum = minimum;
            this.maximum = maximum;
#endif
        }

        /// <include file='../../_Doc/System.ComponentModel.DataAnnotations.xml' path='doc/members/member[@name="M:System.ComponentModel.DataAnnotations.RangeAttribute.#ctor(System.Int32,System.Int32)"]/*' />
        public RangeAttribute(int minimum, int maximum)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#else
            this.minimum = minimum;
            this.maximum = maximum;
#endif
        }

        #endregion

        #region PROPERTIES

        /// <include file='../../_Doc/System.ComponentModel.DataAnnotations.xml' path='doc/members/member[@name="P:System.ComponentModel.DataAnnotations.RangeAttribute.Minimum"]/*' />
        public object Minimum
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return minimum;
#endif
            }
        }

        /// <include file='../../_Doc/System.ComponentModel.DataAnnotations.xml' path='doc/members/member[@name="P:System.ComponentModel.DataAnnotations.RangeAttribute.Maximum"]/*' />
        public object Maximum
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#else
                return maximum;
#endif
            }
        }

        #endregion
    }
}