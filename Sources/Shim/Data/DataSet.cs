namespace System.Data
{
    public sealed class DataSet
    {
        public DataSet()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif            
        }

        public DataSet(string dataSetName)
            : this()
        {
#if PCL
            throw new PlatformNotSupportedException("PCL");
#endif
        }
    }
}