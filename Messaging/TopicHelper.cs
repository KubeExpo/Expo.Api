using System;
using System.Text;
using RabbitMQ.Client;

namespace Expo.Api.Messaging
{
    public class TopicHelper
    {
        public void SendMessage(string Message)
        {
            //Main entry point to the RabbitMQ .NET AMQP client

            var connectionFactory = new ConnectionFactory()
            {
                UserName = "guest",
                Password = "guest",
                HostName = "arch-pc",
                Port = 5672
            };
            var connection = connectionFactory.CreateConnection();
            var model = connection.CreateModel();
            var properties = model.CreateBasicProperties();
            properties.Persistent = false;
            byte[] messagebuffer = Encoding.Default.GetBytes(Message);
            model.BasicPublish("topic.account", "message.account.created", properties, messagebuffer);
            Console.WriteLine("Message Sent From: topic.account");
            Console.WriteLine("Routing Key: message.account.created");
            Console.WriteLine("Message Sent");
        }
    }
}