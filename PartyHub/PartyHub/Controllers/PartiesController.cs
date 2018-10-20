using PartyHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyHub.ViewModels;
using Microsoft.AspNet.Identity;

namespace PartyHub.Controllers
{
    public class PartiesController : Controller
    {
        private ApplicationDbContext _context;
        public PartiesController()
        {
          _context = new ApplicationDbContext();
        }

        // GET: Parties
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(PartyFormViewModel viewModel)
        {
            var hostId = User.Identity.GetUserId();
            var party = new Party
            {
                HostId = hostId,
                Title = viewModel.Title,
                Description = viewModel.Description,
                Venue = viewModel.Venue,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time))
            };

            _context.Parties.Add(party);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}