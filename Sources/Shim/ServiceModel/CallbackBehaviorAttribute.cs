using System.Transactions;

namespace System.ServiceModel
{
    public sealed class CallbackBehaviorAttribute : Attribute
    {
        public bool AutomaticSessionShutdown
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public IsolationLevel TransactionIsolationLevel
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public bool IncludeExceptionDetailInFaults
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public ConcurrencyMode ConcurrencyMode
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public string TransactionTimeout
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }


        public bool UseSynchronizationContext
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public bool ValidateMustUnderstand
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public bool IgnoreExtensionDataObject
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public int MaxItemsInObjectGraph
        {
            get { throw new PlatformNotSupportedException("PCL"); }
            set { throw new PlatformNotSupportedException("PCL"); }
        }

        public CallbackBehaviorAttribute()
        {
            throw new PlatformNotSupportedException("PCL");
        }
    }
}
