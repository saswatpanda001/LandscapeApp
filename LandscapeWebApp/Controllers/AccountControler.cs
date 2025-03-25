using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LandscapeWebApp.Models;
using LandscapeWebApp.Services;
using Microsoft.EntityFrameworkCore;



namespace LandscapeWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly LandscapeProjectContext _context;

        public AccountController(LandscapeProjectContext context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password && u.Role=="User");
            if (user != null)
            {
                SessionManager.LoggedInUser = user;
                return RedirectToAction("Dashboard", "Account");
            }

            ViewBag.ErrorMessage = "Invalid credentials or you dont have User access";
            return View();
        }

        // Logout
        public IActionResult Logout()
        {
            SessionManager.LoggedInUser = null;
            return Redirect("/Home/Index");
        }
        // GET: Signup
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Signup(User user, string ConfirmPassword)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
            {
                ViewBag.ErrorMessage = "Email is already registered.";
                return View();
            }

            if (user.Password != ConfirmPassword)
            {
                ViewBag.ErrorMessage = "Passwords do not match.";
                return View();
            }

            if (user.Password.Length < 8)
            {
                ViewBag.ErrorMessage = "Password must be at least 8 characters long.";
                return View();
            }

            user.CreatedAt = DateTime.Now;
            user.Role = "User";

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            SessionManager.LoggedInUser = user; // Automatically log in the user after signup

            return RedirectToAction("Login", "Account");
        }


        public IActionResult Dashboard()
        {
            if (SessionManager.LoggedInUser == null)
            {
                return RedirectToAction("/");
            }
            return View(SessionManager.LoggedInUser);
        }

        [HttpGet]
        public IActionResult EditProfile()
        {
            var user = SessionManager.LoggedInUser;
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == SessionManager.LoggedInUser.UserId);

            if (user == null)
            {
                ViewBag.ErrorMessage = "User not found.";
                return View(updatedUser);
            }

            // Update only editable fields
            user.Name = updatedUser.Name;
            user.Phone = updatedUser.Phone;
            user.Address = updatedUser.Address;
            user.Password = updatedUser.Password;

            await _context.SaveChangesAsync();
            ViewBag.SuccessMessage = "Profile updated successfully!";
            SessionManager.LoggedInUser = user;

            return View(user);
        }

        // GET: Password Reset Page
        public IActionResult ResetPassword()
        {
            return View();
        }

        // POST: Handle Password Reset
        [HttpPost]
        public async Task<IActionResult> ResetPassword(string email, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                ViewBag.ErrorMessage = "All fields are required.";
                return View();
            }

            if (password != confirmPassword)
            {
                ViewBag.ErrorMessage = "Passwords do not match.";
                return View();
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                ViewBag.ErrorMessage = "No account found with this email.";
                return View();
            }

            user.Password = password; // In real-world apps, hash the password before saving
            await _context.SaveChangesAsync();

            ViewBag.SuccessMessage = "Password has been successfully reset!";
            return View();
        }


        // Display Admin Login Page
        public IActionResult AdminLogin()
        {
            return View();
        }

        // Perform Admin Login
        [HttpPost]
        public IActionResult AdminLogin(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.ErrorMessage = "Both email and password are required.";
                return View();
            }

            // Check if the admin exists with role "Admin"
            var admin = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password && u.Role == "Admin");

            if (admin == null)
            {
                ViewBag.ErrorMessage = "Invalid credentials or you are not an admin.";
                return View();
            }

            SessionManager.LoggedInUser = admin;
            return RedirectToAction("AdminDashboard", "Account");
            
        }


        public async Task<IActionResult> AdminDashboard()
        {

            if (SessionManager.LoggedInUser == null)
            {
                return RedirectToAction("Login");
            }

            // Fetch data for dashboard
            var totalUsers = await _context.Users.CountAsync();
            var totalBookings = await _context.Bookings.CountAsync();
            var totalServices = await _context.Services.CountAsync();

            ViewBag.TotalUsers = totalUsers;
            ViewBag.TotalBookings = totalBookings;
            ViewBag.TotalServices = totalServices;

            return View();
        }








    }
}
