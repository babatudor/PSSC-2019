﻿using MvcExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcExample.Repository
{
	public interface IReservationRepository
	{
		void CreateReservation(Reservation reservation);
		List<Reservation> GetAllReservations();
		Reservation GetReservationById(Guid id);
		void DeleteReservation(Reservation reservation);
	}

	public class ReservationRepository : IReservationRepository
	{
		private readonly List<Reservation> List;

		public ReservationRepository()
		{
			List = new List<Reservation>();
			List.Add(new Reservation
			{
				Id = Guid.NewGuid(),
				Date = DateTime.Now,
				Name = "Tudor",
				WashMachineType = WashMachineType.Gorenje
			});
			List.Add(new Reservation
			{
				Id = Guid.NewGuid(),
				Date = DateTime.Now,
				Name = "Tudor2",
				WashMachineType = WashMachineType.Samsung
			});
			List.Add(new Reservation
			{
				Id = Guid.NewGuid(),
				Date = DateTime.Now,
				Name = "Tudor3",
				WashMachineType = WashMachineType.Samsung
			});
		}

		public void CreateReservation(Reservation reservation)
		{
			List.Add(reservation);
		}

		public void DeleteReservation(Reservation reservation)
		{
			List.Remove(reservation);
		}

		public List<Reservation> GetAllReservations()
		{
			return List;
		}

		public Reservation GetReservationById(Guid id)
		{
			return List.FirstOrDefault(_ => _.Id == id);
		}
	}
}
