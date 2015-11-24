namespace System.ComponentModel
{
    public interface ITypeDescriptorContext : IServiceProvider
    {
        IContainer Container { get; }

        object Instance { get; }

        PropertyDescriptor PropertyDescriptor { get; }

        bool OnComponentChanging();

        void OnComponentChanged();
    }
}
