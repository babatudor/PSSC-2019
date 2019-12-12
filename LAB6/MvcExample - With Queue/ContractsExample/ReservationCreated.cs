using System;

namespace ContractsExample
{
	public class ReservationCreated
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
	}
}
