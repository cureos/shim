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

namespace System.ComponentModel
{
    /// <include file='../_Doc/System.xml' path='doc/members/member[@name="T:System.ComponentModel.DescriptionAttribute"]/*' />
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class DescriptionAttribute : Attribute
    {
        #region FIELDS

        private readonly string _description;
        
        #endregion

        #region CONSTRUCTORS

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="M:System.ComponentModel.DescriptionAttribute.#ctor(System.String)"]/*' />
        public DescriptionAttribute(string description)
        {
            _description = description;
        }

        #endregion

        #region PROPERTIES

        /// <include file='../_Doc/System.xml' path='doc/members/member[@name="P:System.ComponentModel.DescriptionAttribute.Description"]/*' />
        public string Description
        {
            get { return _description; }
        }

        #endregion
    }
}