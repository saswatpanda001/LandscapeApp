using System;
using System.Collections.Generic;

#nullable disable

namespace LandscapeWebApp.Models
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
