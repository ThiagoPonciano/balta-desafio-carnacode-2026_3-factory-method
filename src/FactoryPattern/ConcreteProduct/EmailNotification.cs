using FactoryPattern.IProduct;

namespace FactoryPattern.ConcreteProduct
{
    public class EmailNotification : INotification
    {
        private string Recipient;
        private string Subject;
        private string Body;
        private bool IsHtml;

        public void Configure(string recipient, string subject, string message)
        {
            Recipient = recipient;
            Subject = subject;
            Body = message;
            IsHtml = true;
        }

        public void Send()
        {
            Console.WriteLine($"   Enviando Email para {Recipient}");
            Console.WriteLine($"   Assunto: {Subject}");
            Console.WriteLine($"   Mensagem: {Body}");
        }
    }
}
