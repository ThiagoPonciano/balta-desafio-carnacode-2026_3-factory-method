using FactoryPattern.IProduct;

namespace FactoryPattern.Creator
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void SendNotification(string recipient, string subject, string message)
        {
            var notification = CreateNotification();

            notification.Configure(recipient, subject, message);

            notification.Send();
        }
    }
}
