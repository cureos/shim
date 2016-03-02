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

using System.Threading.Tasks;
using Windows.Storage;

namespace System.IO
{
	internal static class FileHelper
	{
		#region METHODS

		public static async Task<StorageFile> CreateStorageFileAsync(string path)
		{
			var folderName = Path.GetDirectoryName(path);
			if (!Directory.Exists(folderName)) Directory.CreateDirectory(folderName);
			var folder = await StorageFolder.GetFolderFromPathAsync(folderName);

			var fileName = Path.GetFileName(path);
			return await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
		}

		public static async Task<StorageFile> GetStorageFileAsync(string path)
		{
			var folderName = Path.GetDirectoryName(path);
			if (!Directory.Exists(folderName)) throw new FileNotFoundException("Cannot find specified folder.");
			var folder = await StorageFolder.GetFolderFromPathAsync(folderName);

			var fileName = Path.GetFileName(path);
			return await folder.GetFileAsync(fileName);
		}
		
		#endregion
	}
}