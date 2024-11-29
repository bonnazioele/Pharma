using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pharma.Data;
using Pharma.Models;
using System;
using System.Linq;

namespace Pharma.Controllers
{
    public class HomeController : Controller
    {
        private readonly PharmaContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(PharmaContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                // Retrieve the list of medicines from the database
                var medicines = _context.Medicines.ToList();

                // Pass the list of medicines to the view
                return View(medicines);
            }
            catch (Exception ex)
            {
                // Log the error with detailed information
                _logger.LogError(ex, "Error occurred while fetching medicines in HomeController.");

                // Display an error message or redirect to an error view
                return View("Error", new { message = "An error occurred while loading the medicines list. Please try again later." });
            }
        }
    }
}
