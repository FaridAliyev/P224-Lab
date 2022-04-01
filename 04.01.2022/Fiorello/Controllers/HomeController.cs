using Fiorello.DAL;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                SliderImages = await _db.SliderImages.ToListAsync(),
                SliderText = await _db.SliderTexts.FirstOrDefaultAsync(),
                Categories = await _db.Categories.ToListAsync(),
                Products = await _db.Products.Include(p => p.Category).ToListAsync(),
                About = await _db.Abouts.FirstOrDefaultAsync(),
                AboutFeatures = await _db.AboutFeatures.ToListAsync(),
                Experts = await _db.Experts.Include(e => e.Position).ToListAsync()
            };

            return View(model);
        }
    }
}
