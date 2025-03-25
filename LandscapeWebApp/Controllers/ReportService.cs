using System;
using System.IO;
using System.Linq;
using System.Text;
using LandscapeWebApp.Models;

public class ReportService
{
    private readonly LandscapeProjectContext _context;

    public ReportService(LandscapeProjectContext context)
    {
        _context = context;
    }

    public string GenerateCsvReport()
    {
        var sb = new StringBuilder();

        // Users Data
        sb.AppendLine("Users Report");
        sb.AppendLine("UserId,Name,Email,Phone,Address,Role,CreatedAt");
        var users = _context.Users.ToList();
        foreach (var user in users)
        {
            sb.AppendLine($"{user.UserId},{user.Name},{user.Email},{user.Phone},{user.Address},{user.Role},{user.CreatedAt}");
        }
        sb.AppendLine();

        // Services Data
        sb.AppendLine("Services Report");
        sb.AppendLine("ServiceId,ServiceName,Description,Price,Duration");
        var services = _context.Services.ToList();
        foreach (var service in services)
        {
            sb.AppendLine($"{service.ServiceId},{service.ServiceName},{service.Description},{service.Price},{service.Duration}");
        }
        sb.AppendLine();

        // Bookings Data
        sb.AppendLine("Bookings Report");
        sb.AppendLine("BookingId,UserId,UserName,ServiceId,ServiceName,BookingDate,Status,CreatedAt");
        var bookings = _context.Bookings
            .Select(b => new
            {
                b.BookingId,
                b.UserId,
                UserName = b.User.Name,
                b.ServiceId,
                ServiceName = b.Service.ServiceName,
                b.BookingDate,
                b.Status,
                b.CreatedAt
            }).ToList();

        foreach (var booking in bookings)
        {
            sb.AppendLine($"{booking.BookingId},{booking.UserId},{booking.UserName},{booking.ServiceId},{booking.ServiceName},{booking.BookingDate},{booking.Status},{booking.CreatedAt}");
        }

        return sb.ToString();
    }
}
