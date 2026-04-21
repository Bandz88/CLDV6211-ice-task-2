using Microsoft.AspNetCore.Mvc;
using Kias_Kar_Kompany.Data;
using Kias_Kar_Kompany.Models;
using Microsoft.EntityFrameworkCore;

namespace Kias_Kar_Kompany.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.ToListAsync());
        }
    }
}