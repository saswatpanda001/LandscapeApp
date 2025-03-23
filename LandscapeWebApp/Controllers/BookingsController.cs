using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LandscapeWebApp.Models;

namespace LandscapeWebApp.Controllers
{
    public class BookingsController : Controller
    {
        private readonly LandscapeProjectContext _context;

        public BookingsController(LandscapeProjectContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var landscapeProjectContext = _context.Bookings.Include(b => b.Service).Include(b => b.User);
            return View(await landscapeProjectContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Service)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,UserId,ServiceId,BookingDate,Status,CreatedAt")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName", booking.ServiceId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName", booking.ServiceId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,UserId,ServiceId,BookingDate,Status,CreatedAt")] Booking booking)
        {
            if (id != booking.BookingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName", booking.ServiceId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Service)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }


        // Display Bookings for Bulk Delete
        public async Task<IActionResult> BulkDeleteBookings()
        {
            var bookings = await _context.Bookings
                                          .Include(b => b.User)
                                          .Include(b => b.Service)
                                          .ToListAsync();
            return View(bookings);
        }

        // Perform Bulk Delete
        [HttpPost]
        public async Task<IActionResult> BulkDeleteBookings(List<int> bookingIds)
        {
            if (bookingIds == null || bookingIds.Count == 0)
            {
                TempData["ErrorMessage"] = "No bookings selected.";
                return RedirectToAction("BulkDeleteBookings");
            }

            var bookingsToDelete = await _context.Bookings
                                                  .Where(b => bookingIds.Contains(b.BookingId))
                                                  .ToListAsync();
            if (bookingsToDelete.Any())
            {
                _context.Bookings.RemoveRange(bookingsToDelete);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Selected bookings deleted successfully!";
            }
            else
            {
                TempData["ErrorMessage"] = "Bookings not found.";
            }

            return RedirectToAction("BulkDeleteBookings");
        }






















    }
}
