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

using System.Linq;

using Windows.Networking;
using Windows.Networking.Connectivity;

namespace System
{
    /// <summary>
    /// Shim complement for the <see cref="Environment"/> class, providing members that are
    /// not included in the PCL member subset of the <see cref="Environment"/> class.
    /// </summary>
    public static class ShimEnvironment
    {
        /// <include file='../_Doc/mscorlib.xml' path='doc/members/member[@name="P:System.Environment.MachineName"]/*' />
        ///<remarks>
        /// Want to store the hostname to send for push notifications to make
        /// the management UI better. Take the substring up to the first period
        /// of the first DomainName entry.
        /// Thanks to Jeff Wilcox and Matthijs Hoekstra
        /// Adapted from Q42.WinRT library at https://github.com/Q42/Q42.WinRT
        ///</remarks>
        public static string MachineName
        {
            get
            {
                var list = NetworkInformation.GetHostNames().ToArray();
                string name = null;
                if (list.Length > 0)
                {
                    foreach (var entry in list)
                    {
                        if (entry.Type == HostNameType.DomainName)
                        {
                            var s = entry.CanonicalName;
                            if (!String.IsNullOrEmpty(s))
                            {
                                // Domain-joined. Requires at least a one-character name.
                                var j = s.IndexOf('.');

                                if (j > 0)
                                {
                                    name = s.Substring(0, j);
                                    break;
                                }

                                // Typical home machine.
                                name = s;
                            }
                        }
                    }
                }

                if (String.IsNullOrEmpty(name))
                {
                    // TODO: Localize?
                    name = "Unknown Windows 8";
                }

                return name;
            }
        }
    }
}