using FactoryPattern.ConcreteProduct;
using FactoryPattern.Creator;
using FactoryPattern.IProduct;

namespace FactoryPattern.ConcreteCreators
{
    public class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
