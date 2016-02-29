using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
    // Résumé :
    //     Spécifie quel type utiliser comme convertisseur pour l'objet auquel cet attribut
    //     est lié.
    [AttributeUsage(AttributeTargets.All)]
    public sealed class TypeConverterAttribute : Attribute
    {
        public static readonly TypeConverterAttribute Default;

        public TypeConverterAttribute(string typeName)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }
      
        public TypeConverterAttribute(Type type)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }
      
        public string ConverterTypeName { get; set; }

        public override bool Equals(object obj)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public override int GetHashCode()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }

    public class TypeConverter
    {
        public bool CanConvertFrom(Type sourceType)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public bool CanConvertTo(Type destinationType)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public object ConvertFrom(object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public object ConvertFromInvariantString(string text)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public object ConvertFromString(string text)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }
        
        public object ConvertFromString(ITypeDescriptorContext context, string text)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public object ConvertTo(object value, Type destinationType)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public string ConvertToInvariantString(object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public string ConvertToInvariantString(ITypeDescriptorContext context, object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public string ConvertToString(object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public string ConvertToString(ITypeDescriptorContext context, object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public object CreateInstance(IDictionary propertyValues)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public bool GetCreateInstanceSupported()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    
        public bool GetPropertiesSupported()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public ICollection GetStandardValues()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public bool GetStandardValuesExclusive()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public bool GetStandardValuesSupported()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public bool IsValid(object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public virtual bool IsValid(ITypeDescriptorContext context, object value)
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }

        public class StandardValuesCollection : ICollection, IEnumerable
        {      
            public int Count
            {
                get
                {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
                }
            }

            public object this[int index]
            {
                get
                {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
                }
            }

            int ICollection.Count
            {
                get
                {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
                }
            }

            bool ICollection.IsSynchronized
            {
                get
                {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
                }
            }

            object ICollection.SyncRoot
            {
                get
                {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
                }
            }

            public StandardValuesCollection(ICollection values)
            {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
            }

            public void CopyTo(Array array, int index)
            {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
            }

            public IEnumerator GetEnumerator()
            {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
            }

            void ICollection.CopyTo(Array array, int index)
            {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
            }
        }
    }
}
