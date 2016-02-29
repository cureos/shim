namespace System
{
    /// <summary>
    /// PCL extensions for int class.
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Compares an int to another.
        /// </summary>
        /// <param name="integer">The integer.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="System.ArgumentException">Value to compare must be an int;@value</exception>
        public static int CompareTo(this int integer, object value)
        {
#if DOTNET
            return integer.CompareTo(value);
#else
            if (value == null)
            {
                return 1;
            }

            if (value is int)
            {
                // Need to use compare because subtraction will wrap
                // to positive for very large neg numbers, etc. 
                int i = (int)value;
                if (integer < i)
                {
                    return -1;
                }

                if (integer > i)
                {
                    return 1;
                }

                return 0;
            }

            throw new ArgumentException("Value to compare must be an int", @"value");
#endif
        }
    }
}
