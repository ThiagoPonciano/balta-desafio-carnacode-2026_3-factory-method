namespace FactoryPattern.IProduct
{
    public interface INotification
    {
        void Configure(string recipient, string subject, string message);
        void Send();
    }
}
