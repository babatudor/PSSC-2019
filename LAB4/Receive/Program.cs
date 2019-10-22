using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using Newtonsoft.Json;
using Test;

namespace Receive
{
    class Program
    {
        public static void Main()
        {
            var factory = new ConnectionFactory() 
            {
                Uri = new Uri("amqp://ltgahriq:zRvmj4P_J2aWscJ-Qrx6mQQtTjEmdARe@dove.rmq.cloudamqp.com/ltgahriq"),
                UserName = "ltgahriq" ,
                Password = "zRvmj4P_J2aWscJ-Qrx6mQQtTjEmdARe",
            };
            
            using(var connection = factory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "test", durable: false, exclusive: false, autoDelete: false, arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    var jsonText = JsonConvert.DeserializeObject<Model>(message);
                    
                    Console.WriteLine("Received {0}", $"{jsonText.TestString} {jsonText.TestInt}");
                };
                
                channel.BasicConsume(queue: "test", autoAck: true, consumer: consumer);

                Console.WriteLine("Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
