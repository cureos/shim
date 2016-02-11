// Decompiled with JetBrains decompiler
// Type: System.ComponentModel.LocalizableAttribute
// Assembly: System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// MVID: 15344E16-9439-46DE-A8DF-0349E8603E3D
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\MonoAndroid\v1.0\System.dll

namespace System.ComponentModel
{
    /// <summary>
    /// Localizable attribute shim
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class LocalizableAttribute : Attribute
    {
        /// <summary>
        /// To be added.
        /// </summary>
        /// 
        /// <remarks>
        /// To be added.
        /// </remarks>
        public static readonly LocalizableAttribute Yes = new LocalizableAttribute(true);
        /// <summary>
        /// To be added.
        /// </summary>
        /// 
        /// <remarks>
        /// To be added.
        /// </remarks>
        public static readonly LocalizableAttribute No = new LocalizableAttribute(false);
        /// <summary>
        /// To be added.
        /// </summary>
        /// 
        /// <remarks>
        /// To be added.
        /// </remarks>
        public static readonly LocalizableAttribute Default = LocalizableAttribute.No;
        private bool isLocalizable;

        /// <summary>
        /// To be added.
        /// </summary>
        /// 
        /// <value>
        /// To be added.
        /// </value>
        /// 
        /// <remarks>
        /// To be added.
        /// </remarks>
        public bool IsLocalizable
        {
            get
            {
#if PCL
                throw new PlatformNotSupportedException("PCL");
#endif
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizableAttribute"/> class.
        /// </summary>
        /// <param name="isLocalizable">if set to <c>true</c> [is localizable].</param>
        /// <exception cref="System.PlatformNotSupportedException">PCL</exception>
        public LocalizableAttribute(bool isLocalizable)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <param name="obj">To be added.</param>
        /// <summary>
        /// To be added.
        /// </summary>
        /// 
        /// <returns>
        /// To be added.
        /// </returns>
        /// 
        /// <remarks>
        /// To be added.
        /// </remarks>
        public override bool Equals(object obj)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// 
        /// <returns>
        /// To be added.
        /// </returns>
        /// 
        /// <remarks>
        /// To be added.
        /// </remarks>
        public override int GetHashCode()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }
}
