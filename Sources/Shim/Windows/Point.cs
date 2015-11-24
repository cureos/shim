namespace System.Windows
{
    /// <summary>
    /// Xamarin impl for windows point.
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Constructor which accepts the X and Y values
        /// </summary>
        /// <param name="x">The value for the X coordinate of the new Point</param>
        /// <param name="y">The value for the Y coordinate of the new Point</param>
        public Point(double x, double y)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public double X
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public double Y
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        /// <summary>
        /// Offset - update the location by adding offsetX to X and offsetY to Y
        /// </summary>
        /// <param name="offsetX"> The offset in the x dimension </param>
        /// <param name="offsetY"> The offset in the y dimension </param>
        public void Offset(double offsetX, double offsetY)
        {
            throw new PlatformNotSupportedException("PCL");
        }
    }
}