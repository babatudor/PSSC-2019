using System;
using System.Collections.Generic;
using System.Text;

namespace ContractsExample
{
	public class ReservationDeleted
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
	}
}
