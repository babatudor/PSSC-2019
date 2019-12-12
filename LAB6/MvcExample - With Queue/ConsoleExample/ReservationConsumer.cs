using ContractsExample;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace ConsoleExample
{
	public class ReservationConsumer 
		: IConsumer<ReservationCreated>,
		  IConsumer<ReservationDeleted>
	{
		public async Task Consume(ConsumeContext<ReservationCreated> context)
		{
			var message = $"Reservation created: {context.Message.Id}, Name: {context.Message.Name} ({context.Message.Date.ToShortDateString()})";
			await Console.Out.WriteLineAsync(message);
		}

		public async Task Consume(ConsumeContext<ReservationDeleted> context)
		{
			var message = $"Reservation deleted: {context.Message.Id}, Name: {context.Message.Name} ({context.Message.Date.ToShortDateString()})";
			await Console.Out.WriteLineAsync(message);
		}
	}
}
