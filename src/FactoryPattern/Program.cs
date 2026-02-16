using FactoryPattern.ConcreteCreators;
using FactoryPattern.Creator;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações com Factory Method ===\n");

            NotificationCreator creator;

            creator = new EmailNotificationCreator();
            creator.SendNotification(
                "cliente@email.com",
                "Confirmação de Pedido",
                "Seu pedido 12345 foi confirmado!"
            );

            Console.WriteLine();

            creator = new SmsNotificationCreator();
            creator.SendNotification(
                "+5511999999999",
                "",
                "Pedido 12346 confirmado!"
            );

            Console.WriteLine();

            creator = new PushNotificationCreator();
            creator.SendNotification(
                "device-token-abc123",
                "Pedido Enviado",
                "Rastreamento: BR123456789"
            );

            Console.WriteLine();

            creator = new WhatsAppNotificationCreator();
            creator.SendNotification(
                "+5511888888888",
                "",
                "Pagamento pendente: R$ 150,00"
            );
        }
    }
}