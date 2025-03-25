using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandscapeWebApp.Models;
using LandscapeWebApp.Controllers;
using LandscapeWebApp.Services;
using System;


namespace LandscapeWebApp.Controllers
{
    public class UserServiceController : Controller
    {
        private readonly LandscapeProjectContext _context;

        // Constructor to inject LandscapeProjectContext
        public UserServiceController(LandscapeProjectContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }

        public async Task<IActionResult> Details(int id)
        {
            // Find the service by ID
            var service = await _context.Services.FirstOrDefaultAsync(s => s.ServiceId == id);

            if (service == null)
            {
                TempData["ErrorMessage"] = "Service not found.";
                return RedirectToAction("Index"); // Redirect to service list
            }

            // Pass Success or Error messages from TempData (if any)
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            ViewBag.ErrorMessage = TempData["ErrorMessage"];

            return View(service);
        }


        // Display all bookings for the logged-in user
        public async Task<IActionResult> Bookings()
        {
            if (SessionManager.LoggedInUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var userId = SessionManager.LoggedInUser.UserId;

            var bookings = await _context.Bookings
                .Include(b => b.Service)
                .Where(b => b.UserId == userId)
                .ToListAsync();

            return View(bookings);
        }

        // Cancel Booking
        public async Task<IActionResult> CancelBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);

            if (booking == null || booking.UserId != SessionManager.LoggedInUser.UserId)
            {
                return NotFound();
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Booking cancelled successfully!";
            return RedirectToAction("Index");
        }

        // Display Booking Form
        [HttpGet]
        public async Task<IActionResult> Book(int id)
        {
            if (SessionManager.LoggedInUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var service = await _context.Services.FirstOrDefaultAsync(s => s.ServiceId == id);

            if (service == null)
            {
                return NotFound();
            }

            ViewBag.Service = service;
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Book(int id, DateTime bookingDate)
        {
            if (SessionManager.LoggedInUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (bookingDate < DateTime.Today)
            {
                ViewBag.ErrorMessage = "Booking date cannot be in the past.";
                var service = await _context.Services.FirstOrDefaultAsync(s => s.ServiceId == id);
                ViewBag.Service = service;
                return View();
            }

            var booking = new Booking
            {
                UserId = SessionManager.LoggedInUser.UserId,
                ServiceId = id,
                BookingDate = bookingDate,
                Status = "Booked",
                CreatedAt = DateTime.Now
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Service booked successfully!";
            return RedirectToAction("Index");
        }






    }
}
