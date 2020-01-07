using System;
using System.Collections.Generic;
using System.Text;
using Business.Domain;
using RabbitMQ.Client;




using Newtonsoft.Json;
namespace Business.Service
{
    public class PublishService : IPublishService
    {
        public Model model;
        public ConnectionFactory factory;
        public PublishService()
        {
            factory = new ConnectionFactory()
            {
                Uri = new Uri("amqp://ltgahriq:zRvmj4P_J2aWscJ-Qrx6mQQtTjEmdARe@dove.rmq.cloudamqp.com/ltgahriq"),
                UserName = "ltgahriq",
                Password = "zRvmj4P_J2aWscJ-Qrx6mQQtTjEmdARe",
            };
            model = new Model()
            {
                TestInt = 1,
                TestString = "merge"
            };
           
        }
        public void Publish()
        {
            SendMessage(factory, model);
        }






        public void SendMessage(ConnectionFactory factory, Model model)
        {
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "test", durable: false, exclusive: false, autoDelete: false, arguments: null);


                var json = JsonConvert.SerializeObject(model);
                var body = Encoding.UTF8.GetBytes(json);

                channel.BasicPublish(exchange: "", routingKey: "test", basicProperties: null, body: body);
            }
        }
    }
}




