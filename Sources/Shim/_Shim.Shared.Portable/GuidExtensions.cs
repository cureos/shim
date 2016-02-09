using System.Globalization;

namespace System
{
    /// <summary>
    /// PCL extensions for GUID class.
    /// </summary>
    public static class GuidExtensions
    {
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <param name="n">The n.</param>
        /// <param name="c">The c.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public static string ToString(this Guid o, string n, NumberFormatInfo c)
        {
            return o.ToString(n);
        }
    }
}
