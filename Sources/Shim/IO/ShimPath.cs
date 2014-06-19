/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of Shim.NET.
 *
 *  Shim.NET is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Shim.NET is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Shim.NET.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.IO
{
#if NETFX_CORE
    using global::Windows.Storage;
#endif

    public static class ShimPath
    {
        #region METHODS

        public static string GetTempPath()
        {
#if NETFX_CORE
            return ApplicationData.Current.TemporaryFolder.Path;
#elif WINDOWS_PHONE || DOTNET
            return Path.GetTempPath();
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public static string GetTempFileName()
        {
#if NETFX_CORE
            const string DefaultFileExtension = ".tmp";
            return Path.ChangeExtension(global::System.IO.Path.Combine(GetTempPath(),
                                                  global::System.IO.Path.GetRandomFileName()), DefaultFileExtension);
#elif WINDOWS_PHONE || DOTNET
            return Path.GetTempFileName();
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public static string GetFullPath(string path)
        {
#if NETFX_CORE
            return path;
#elif WINDOWS_PHONE || DOTNET
            return Path.GetFullPath(path);
#else
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public static string Combine(params string[] paths)
        {
            return Path.Combine(paths);
        }

        #endregion
    }
}