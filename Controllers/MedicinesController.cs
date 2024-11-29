using Microsoft.AspNetCore.Mvc;
using Pharma.Data;
using Pharma.Models;

namespace Pharmasuit.Controllers
{
    public class MedicineController : Controller
    {
        private readonly PharmaContext _context;

        public MedicineController(PharmaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var medicines = _context.Medicines.ToList();
            return View(medicines);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                _context.Medicines.Add(medicine);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(medicine);
        }
    }
}
