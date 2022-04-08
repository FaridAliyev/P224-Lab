using Fiorello.DAL;
using Fiorello.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Product> products = await _db.Products.ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return RedirectToAction("Index","Product");
            }
            List<Product> products = await _db.Products.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> SearchPartial(string query)
        {
            List<Product> products = await _db.Products.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToListAsync();
            return PartialView("_ProductSearchPartial",products);
        }
    }
}
