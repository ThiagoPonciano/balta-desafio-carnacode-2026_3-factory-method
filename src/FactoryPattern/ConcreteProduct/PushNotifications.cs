using FactoryPattern.IProduct;

namespace FactoryPattern.ConcreteProduct
{
    public class PushNotifications : INotification
    {
        private string DeviceToken;
        private string Title;
        private string Message;
        private int Badge;

        public void Configure(string recipient, string subject, string message)
        {
            DeviceToken = recipient;
            Title = subject;
            Message = message;
            Badge = 1;
        }

        public void Send()
        {
            Console.WriteLine($"   Enviando Push para dispositivo {DeviceToken}");
            Console.WriteLine($"   Título: {Title}");
            Console.WriteLine($"   Mensagem: {Message}");
        }
    }
}
