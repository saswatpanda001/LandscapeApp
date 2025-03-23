using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandscapeWebApp.Controllers
{
    public class UserService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // Display all services
        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }

        // Display service details by ID
        public async Task<IActionResult> Details(int id)
        {
            var service = await _context.Services.FirstOrDefaultAsync(s => s.ServiceId == id);

            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

    }
}
