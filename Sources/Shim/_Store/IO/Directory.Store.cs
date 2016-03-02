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

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Search;

namespace System.IO
{
    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.Directory"]/*' />
    public static class Directory
    {
        #region FIELDS

        private const char DirectorySeparatorChar = '\\';

        #endregion

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Directory.Exists(System.String)"]/*' />
        public static bool Exists(string path)
        {
            try
            {
                var folder = Task.Run(async () => await GetStorageFolder(path)).Result;
                return folder != null;
            }
            catch
            {
                return false;
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Directory.CreateDirectory(System.String)"]/*' />
        public static DirectoryInfo CreateDirectory(string path)
        {
            try
            {
                Task.Run(async () =>
                                   {
                                       var subFolders = new Stack<string>();
                                       var root = Path.GetDirectoryName(path.TrimEnd(DirectorySeparatorChar) + DirectorySeparatorChar);
                                       while (!String.IsNullOrEmpty(root) && !Exists(root))
                                       {
                                           subFolders.Push(root.Substring(root.LastIndexOf(DirectorySeparatorChar) + 1));
                                           root = Path.GetDirectoryName(root);
                                       }
                                       if (String.IsNullOrEmpty(root))
                                           throw new ArgumentException("Failed to identify an existing root folder.");

                                       var rootFolder = await StorageFolder.GetFolderFromPathAsync(root);
                                       while (subFolders.Count > 0)
                                       {
                                           rootFolder = await rootFolder.CreateFolderAsync(subFolders.Pop());
                                       }
                                   }).Wait();
                return new DirectoryInfo(path);
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Directory.GetDirectories(System.String)"]/*' />
        public static string[] GetDirectories(string path)
        {
            var folders = Task.Run(async () =>
                                             {
                                                 var root = await GetStorageFolder(path);
                                                 return await root.GetFoldersAsync();
                                             }).Result;
            return folders.Select(folder => folder.Name).ToArray();
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Directory.GetFiles(System.String)"]/*' />
        public static string[] GetFiles(string path)
        {
            return GetFiles(path, "*");
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Directory.GetFiles(System.String,System.String)"]/*' />
        public static string[] GetFiles(string path, string searchPattern)
        {
            var files = Task.Run(async () =>
                                           {
                                               var folder = await GetStorageFolder(path);
                                               var fileQuery =
                                                   folder.CreateFileQueryWithOptions(new QueryOptions
                                                                                         {
                                                                                             UserSearchFilter = searchPattern
                                                                                         });
                                               return await fileQuery.GetFilesAsync();
                                           }).Result;

            return files.Select(file => file.Path).ToArray();
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.Directory.Move(System.String,System.String)"]/*' />
        public static void Move(string sourceDirName, string destDirName)
        {
            // TODO Implement support for identifying and moving individual files
            Task.Run(
                async () =>
                    {
                        var sourceDir = await StorageFolder.GetFolderFromPathAsync(sourceDirName);
                        await sourceDir.RenameAsync(destDirName, NameCollisionOption.FailIfExists);
                    });
        }

        /// <summary>
        /// Get storage folder from specified directory path.
        /// </summary>
        /// <param name="path">Directory path.</param>
        /// <returns>Storage folder (task) for specified directory path.</returns>
        private static async Task<StorageFolder> GetStorageFolder(string path)
        {
            var directoryName = Path.GetDirectoryName(path.TrimEnd(DirectorySeparatorChar) + DirectorySeparatorChar);
            return await StorageFolder.GetFolderFromPathAsync(directoryName);
        }
    }
}