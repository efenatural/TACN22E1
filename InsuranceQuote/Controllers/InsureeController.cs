
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using InsuranceQuote.Models;

namespace InsuranceQuote.Controllers
{
    public class InsureeController : Controller
    {
        private readonly InsuranceContext _context;

        public InsureeController(InsuranceContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Insurees.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Insuree insuree)
        {
            insuree.Quote = CalculateQuote(insuree);
            if (ModelState.IsValid)
            {
                _context.Add(insuree);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        private decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50m;

            if (insuree.Age <= 18) quote += 100m;
            else if (insuree.Age <= 25) quote += 50m;
            else quote += 25m;

            if (insuree.CarYear < 2000) quote += 25m;
            else if (insuree.CarYear > 2015) quote += 25m;

            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25m;
                if (insuree.CarModel.ToLower() == "911 carrera") quote += 25m;
            }

            quote += insuree.SpeedingTickets * 10m;

            if (insuree.DUI) quote *= 1.25m;
            if (insuree.FullCoverage) quote *= 1.5m;

            return quote;
        }

        public IActionResult Admin()
        {
            var insurees = _context.Insurees.Select(i => new
            {
                i.FirstName,
                i.LastName,
                i.EmailAddress,
                i.Quote
            }).ToList();
            return View(insurees);
        }
    }
}
