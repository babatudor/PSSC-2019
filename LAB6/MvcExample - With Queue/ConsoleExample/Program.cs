using MassTransit;
using System;

namespace ConsoleExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
			{
				sbc.Host(new Uri("amqp://wsdtxtjx:Iw-juKWR7DZu4FFWzx7fAC-88ZFxSYPS@hawk.rmq.cloudamqp.com/wsdtxtjx"), h =>
				{
					h.Username("wsdtxtjx");
					h.Password("Iw-juKWR7DZu4FFWzx7fAC-88ZFxSYPS");
				});

				sbc.ReceiveEndpoint(e =>
				{
					e.Consumer<ReservationConsumer>();
				});
			});

			bus.Start();

			Console.WriteLine("Press any key to exit");
			Console.ReadKey();

		}
	}
}
