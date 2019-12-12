using ContractsExample;
using MassTransit;
using MvcExample.Models;
using MvcExample.Repository;
using System;
using System.Collections.Generic;

namespace MvcExample.Services
{
	public interface IReservationService
	{
		void CreateReservation(Reservation reservation);
		List<Reservation> GetAllReservations();
		Reservation GetReservationById(Guid id);
		void DeleteReservation(Guid id);
	}

	public class ReservationService : IReservationService
	{
		private readonly IBusControl bus;
		private readonly IReservationRepository repository;

		public ReservationService(IBusControl bus, IReservationRepository repository)
		{
			this.bus = bus;
			this.repository = repository;
		}

		public void CreateReservation(Reservation reservation)
		{
			reservation.Id = Guid.NewGuid();
			repository.CreateReservation(reservation);

			bus.Publish(new ReservationCreated()
			{
				Id = reservation.Id,
				Date = reservation.Date,
				Name = reservation.Name
			});
		}

		public void DeleteReservation(Guid id)
		{
			var reservation = repository.GetReservationById(id);
			repository.DeleteReservation(reservation);

			bus.Publish(new ReservationDeleted()
			{
				Id = reservation.Id,
				Date = reservation.Date,
				Name = reservation.Name
			});
		}

		public List<Reservation> GetAllReservations()
		{
			return repository.GetAllReservations();
		}

		public Reservation GetReservationById(Guid id)
		{
			return repository.GetReservationById(id);
		}
	}
}
