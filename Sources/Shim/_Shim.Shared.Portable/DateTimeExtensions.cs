using System.Globalization;

namespace System
{
    /// <summary>
    /// PCL extensions for DateTime class.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Get the short date string.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        public static string ToShortDateString(this DateTime dateTime)
        {
            return dateTime.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
        }
    }
}
