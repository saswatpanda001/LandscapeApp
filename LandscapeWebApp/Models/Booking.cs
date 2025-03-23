using System;
using System.Collections.Generic;

#nullable disable

namespace LandscapeWebApp.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Service Service { get; set; }
        public virtual User User { get; set; }
    }
}
