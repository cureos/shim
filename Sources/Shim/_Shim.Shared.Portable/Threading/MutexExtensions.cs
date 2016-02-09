namespace System.Threading
{
    /// <summary>
    /// PCL extensions for GUID class.
    /// </summary>
    public static class MutexExtensions
    {
        /// <summary>
        /// Closes the specified mutex.
        /// </summary>
        /// <param name="mutex">The mutex.</param>
        public static void Close(this Mutex mutex)
        {
            if (mutex != null)
            {
                mutex.Dispose();
            }
        }
    }
}
