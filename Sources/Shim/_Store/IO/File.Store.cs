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

namespace System.IO
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="T:System.IO.File"]/*' />
    public static class File
    {
        #region METHODS

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Exists(System.String)"]/*' />
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

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Delete(System.String)"]/*' />
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

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Create(System.String)"]/*' />
        public static FileStream Create(string path)
        {
            return new FileStream(path, FileMode.Create);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.CreateText(System.String)"]/*' />
        public static StreamWriter CreateText(string path)
        {
            return new StreamWriter(Create(path));
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.AppendText(System.String)"]/*' />
        public static StreamWriter AppendText(string path)
        {
            return new StreamWriter(new FileStream(path, FileMode.Append));
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.OpenText(System.String)"]/*' />
        public static StreamReader OpenText(string path)
        {
            return new StreamReader(new FileStream(path, FileMode.Open));
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Move(System.String,System.String)"]/*' />
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

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.ReadAllBytes(System.String)"]/*' />
        public static byte[] ReadAllBytes(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open))
            {
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                return bytes;
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.ReadAllLines(System.String)"]/*' />
        public static string[] ReadAllLines(string path)
        {
            return ReadLines(path).ToArray();
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.ReadAllText(System.String)"]/*' />
        public static string ReadAllText(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.ReadLines(System.String)"]/*' />
        public static IEnumerable<string> ReadLines(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                while (reader.Peek() > -1)
                {
                    yield return reader.ReadLine();
                }
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.WriteAllBytes(System.String,System.Byte[])"]/*' />
        public static void WriteAllBytes(string path, byte[] bytes)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.WriteAllLines(System.String,System.String[])"]/*' />
        public static void WriteAllLines(string path, string[] contents)
        {
            IEnumerable<string> e = contents;
            WriteAllLines(path, e);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.WriteAllLines(System.String,System.Collections.Generic.IEnumerable{System.String})"]/*' />
        public static void WriteAllLines(string path, IEnumerable<string> contents)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                foreach (var line in contents) writer.WriteLine(line);
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.WriteAllText(System.String,System.String)"]/*' />
        public static void WriteAllText(string path, string contents)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(contents);
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.AppendAllLines(System.String,System.Collections.Generic.IEnumerable{System.String})"]/*' />
        public static void AppendAllLines(string path, IEnumerable<string> contents)
        {
            using (var stream = new FileStream(path, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            {
                foreach (var line in contents) writer.WriteLine(line);
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.AppendAllText(System.String,System.String)"]/*' />
        public static void AppendAllText(string path, string contents)
        {
            using (var stream = new FileStream(path, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(contents);
            }
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.GetAttributes(System.String)"]/*' />
        public static FileAttributes GetAttributes(string path)
        {
            return FileAttributes.Normal;
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.SetAttributes(System.String,System.IO.FileAttributes)"]/*' />
        public static void SetAttributes(string path, FileAttributes fileAttributes)
        {
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Open(System.String,System.IO.FileMode)"]/*' />
        public static FileStream Open(string path, FileMode mode)
        {
            return new FileStream(path, mode);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Open(System.String,System.IO.FileMode,System.IO.FileAccess)"]/*' />
        public static FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return new FileStream(path, mode, access);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.Open(System.String,System.IO.FileMode,System.IO.FileAccess,System.IO.FileShare)"]/*' />
        public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return new FileStream(path, mode, access, share);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.OpenRead(System.String)"]/*' />
        public static FileStream OpenRead(string path)
        {
            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        }

        /// <include file='../../_Doc/mscorlib.xml' path='doc/members/member[@name="M:System.IO.File.OpenWrite(System.String)"]/*' />
        public static FileStream OpenWrite(string path)
        {
            return new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
        }

        #endregion
    }
}