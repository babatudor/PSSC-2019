using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcExample.Models;
using MvcExample.Services;

namespace MvcExample.Controllers
{
	public class ReservationController : Controller
	{
		private readonly IReservationService reservationService;

		public ReservationController(IReservationService reservationService)
		{
			this.reservationService = reservationService;
		}

		// GET: Reservation
		public ActionResult Index()
		{
			return View(reservationService.GetAllReservations());
		}

		// GET: Reservation/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Reservation/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Reservation/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Reservation reservation)
		{
			try
			{
				reservationService.CreateReservation(reservation);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Reservation/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Reservation/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Reservation/Delete/5
		public ActionResult Delete(Guid id)
		{
			var reservation = reservationService.GetReservationById(id);
			return View(reservation);
		}

		// POST: Reservation/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(Guid id, IFormCollection collection)
		{
			try
			{
				reservationService.DeleteReservation(id);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}