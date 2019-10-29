using System;
using MassTransit;
using System.Threading.Tasks;
using Shared;

namespace Subscriber
{
	public class MessageConsumer : IConsumer<Message>
	{
		public async Task Consume(ConsumeContext<Message> context)
		{
			await Console.Out.WriteLineAsync("subscriber:" + context.Message.Text);
		}
	}
}
