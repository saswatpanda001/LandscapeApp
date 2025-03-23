using System;
using System.Collections.Generic;

#nullable disable

namespace LandscapeWebApp.Models
{
    public partial class Service
    {
        public Service()
        {
            Bookings = new HashSet<Booking>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
