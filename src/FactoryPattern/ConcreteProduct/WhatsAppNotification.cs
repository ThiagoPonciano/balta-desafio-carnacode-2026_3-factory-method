using FactoryPattern.IProduct;

namespace FactoryPattern.ConcreteProduct
{
    public class WhatsAppNotification : INotification
    {
        private string PhoneNumber;
        private string Message;
        private bool UseTemplate;

        public void Configure(string recipient, string subject, string message)
        {
            PhoneNumber = recipient;
            Message = message;
            UseTemplate = true;
        }

        public void Send()
        {
            Console.WriteLine($"  Enviando WhatsApp para {PhoneNumber}");
            Console.WriteLine($"  Mensagem: {Message}");
            Console.WriteLine($"  Template: {UseTemplate}");
        }
    }
}
