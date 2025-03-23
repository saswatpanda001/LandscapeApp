using Microsoft.AspNetCore.Mvc;
using System.Text;
using System;
using LandscapeWebApp.Controllers;

namespace LandscapeWebApp.Controllers
{
    public class ReportController : Controller
    {
        private readonly ReportService _reportService;

        public ReportController(ReportService reportService)
        {
            _reportService = reportService;
        }

        public IActionResult GenerateReport()
        {
            var csvData = _reportService.GenerateCsvReport();
            var bytes = Encoding.UTF8.GetBytes(csvData);
            var fileName = $"Report_{DateTime.Now:yyyyMMddHHmmss}.csv";

            return File(bytes, "text/csv", fileName);
        }
    }
}
