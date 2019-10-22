using System;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using Test;

namespace Send
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
            
            var text = "";
            while (text != "quit")
            {
                text = Console.ReadLine();
                
                var model = new Model(){
                    TestInt = 1,
                    TestString = text
                };

                SendMessage(factory, model);
            }
		}

        private static void SendMessage(ConnectionFactory factory, Model model)
        {
            using(var connection = factory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "test", durable: false, exclusive: false, autoDelete: false, arguments: null);


                var json = JsonConvert.SerializeObject(model);
                var body = Encoding.UTF8.GetBytes(json);

                channel.BasicPublish(exchange: "", routingKey: "test", basicProperties: null, body: body);
            }
        }
    }
}
