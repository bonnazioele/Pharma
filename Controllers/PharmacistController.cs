using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Pharma.Controllers
{
    public class PharmacistController : Controller
    {
        public IActionResult Index()
        {

            [Authorize(Roles = "Pharmacist")]
            public async Task<IActionResult> PharmacistOrders()
            {
                var userId = _userManager.GetUserId(User); // Current logged-in pharmacist's ID

                var orders = await _context.Orders
                    .Where(o => o.PharmacistId == userId || o.Status == "Pending") // Show assigned and pending orders
                    .Include(o => o.User) // Optionally include customer details
                    .ToListAsync();

                return View(orders);
            }

            return View();
        }
    }
}
