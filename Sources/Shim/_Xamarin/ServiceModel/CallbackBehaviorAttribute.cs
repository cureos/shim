using System.Data;

namespace System.ServiceModel
{
    public sealed class CallbackBehaviorAttribute : Attribute
    {
        public bool AutomaticSessionShutdown { get; set; }

        public IsolationLevel TransactionIsolationLevel { get; set; }

        public bool IncludeExceptionDetailInFaults { get; set; }

        public ConcurrencyMode ConcurrencyMode { get; set; }

        public string TransactionTimeout { get; set; }

        public bool UseSynchronizationContext { get; set; }

        public bool ValidateMustUnderstand { get; set; }

        public bool IgnoreExtensionDataObject { get; set; }

        public int MaxItemsInObjectGraph { get; set; }

        public CallbackBehaviorAttribute()
        {            
        }
    }
}
