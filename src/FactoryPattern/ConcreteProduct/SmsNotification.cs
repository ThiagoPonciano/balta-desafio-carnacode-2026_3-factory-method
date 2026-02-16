using FactoryPattern.IProduct;

namespace FactoryPattern.ConcreteProduct
{
    public class SmsNotification : INotification
    {
        private string PhoneNumber;
        private string Message;

        public void Configure(string recipient, string subject, string message)
        {
            PhoneNumber = recipient;
            Message = message;
        }

        public void Send()
        {
            Console.WriteLine($"  Enviando SMS para {PhoneNumber}");
            Console.WriteLine($"  Mensagem: {Message}");
        }
    }
}
