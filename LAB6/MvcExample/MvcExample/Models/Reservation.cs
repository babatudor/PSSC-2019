using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcExample.Models
{
	public class Reservation
	{
		public Guid Id { get; set; }
		public DateTime Date { get; set; }
		public WashMachineType WashMachineType { get; set; }
		public string Name { get; set; }
	}

	public enum WashMachineType
	{
		Bosh,
		Samsung,
		Beko,
		Gorenje,
		Arctic
	}
}
