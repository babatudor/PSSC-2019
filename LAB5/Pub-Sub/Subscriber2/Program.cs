using System;
using MassTransit;

namespace Subscriber2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Subscriber 2!");

			var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
			{
				var host = sbc.Host(new Uri("amqp://wsdtxtjx:Iw-juKWR7DZu4FFWzx7fAC-88ZFxSYPS@hawk.rmq.cloudamqp.com/wsdtxtjx"), h =>
				{
					h.Username("wsdtxtjx");
					h.Password("Iw-juKWR7DZu4FFWzx7fAC-88ZFxSYPS");
				});

				sbc.ReceiveEndpoint(host, e =>
				{
					e.Consumer<MessageConsumer>();
				});
			});

			bus.Start();

			Console.WriteLine("Press any key to exit");
			Console.ReadKey();

			bus.Stop();
		}
	}
}
