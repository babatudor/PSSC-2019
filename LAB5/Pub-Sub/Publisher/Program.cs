using System;
using MassTransit;
using Shared;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Publisher!");

            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri("amqp://wsdtxtjx:Iw-juKWR7DZu4FFWzx7fAC-88ZFxSYPS@hawk.rmq.cloudamqp.com/wsdtxtjx"), h =>
                {
                    h.Username("wsdtxtjx");
                    h.Password("Iw-juKWR7DZu4FFWzx7fAC-88ZFxSYPS");
                });
            });

            bus.Start();

            var message = "";

            while(message != "exit")
            {
                var text = Console.ReadLine();
                var messageObject = new Message
                {
                    Text = text
                };

                bus.Publish<Message>(messageObject);
            }

            bus.Stop();

        }
    }
}
