using FactoryPattern.ConcreteProduct;
using FactoryPattern.Creator;
using FactoryPattern.IProduct;

namespace FactoryPattern.ConcreteCreators
{
    public class WhatsAppNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new WhatsAppNotification();
        }
    }
}
