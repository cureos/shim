// Decompiled with JetBrains decompiler
// Type: System.Runtime.Serialization.IObjectReference
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: A3ACB1D4-0B95-4B38-9BBA-AF334993B0E9
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Serialization
{
    /// <summary>
    /// Indicates that the current interface implementer is a reference to another object.
    /// </summary>
    [ComVisible(true)]
    public interface IObjectReference
    {
        /// <summary>
        /// Returns the real object that should be deserialized, rather than the object that the serialized stream specifies.
        /// </summary>
        /// <returns>
        /// Returns the actual object that is put into the graph.
        /// </returns>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> from which the current object is deserialized. </param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. The call will not work on a medium trusted server.</exception>
        [SecurityCritical]
        object GetRealObject(StreamingContext context);
    }
}
