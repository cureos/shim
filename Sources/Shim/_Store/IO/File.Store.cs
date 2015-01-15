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

namespace System.IO
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public static class File
    {
        #region METHODS

        public static bool Exists(string path)
        {
            try
            {
                return Task.Run(async () => await FileHelper.GetStorageFileAsync(path)).Result != null;
            }
            catch
            {
                return false;
            }
        }

        public static void Delete(string path)
        {
            try
            {
                Task.Run(async () =>
                {
                    var file = await FileHelper.GetStorageFileAsync(path);
                    await file.DeleteAsync();
                }).Wait();
            }
            catch
            {
            }
        }

        public static FileStream Create(string path)
        {
            return new FileStream(path, FileMode.Create);
        }

        public static void Move(string sourceFileName, string destFileName)
        {
            try
            {
                Task.Run(async () =>
                {
                    var src = await FileHelper.GetStorageFileAsync(sourceFileName);
                    var dest = await FileHelper.CreateStorageFileAsync(destFileName);
                    await src.MoveAndReplaceAsync(dest);
                }).Wait();

            }
            catch
            {
            }
        }

        public static byte[] ReadAllBytes(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open))
            {
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                return bytes;
            }
        }

        public static string[] ReadAllLines(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                var lines = new List<string>();
                while (reader.Peek() > -1)
                {
                    lines.Add(reader.ReadLine());
                }

                return lines.ToArray();
            }
        }

        public static void WriteAllBytes(string path, byte[] bytes)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }

        public static void WriteAllText(string path, string contents)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(contents);
            }
        }

        public static FileAttributes GetAttributes(string path)
        {
            return FileAttributes.Normal;
        }

        public static void SetAttributes(string path, FileAttributes attributes)
        {
        }

        public static FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return new FileStream(path, mode, access);
        }

        public static FileStream OpenRead(string path)
        {
            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        }

        public static FileStream OpenWrite(string path)
        {
            return new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
        }

        #endregion
    }
}