using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
                return RedirectToAction("Index", "Product");
            }
            List<Product> products = await _db.Products.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> SearchPartial(string query)
        {
            List<Product> products = await _db.Products.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToListAsync();
            return PartialView("_ProductSearchPartial", products);
        }

        public async Task<IActionResult> AddToCart(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _db.Products.FindAsync(id);

            if (product == null)
            {
                return BadRequest();
            }

            BasketVM basketVM = new BasketVM
            {
                Id = product.Id,
                Quantity = 1
            };

            List<BasketVM> basketVMs = new List<BasketVM>();

            string cookie = HttpContext.Request.Cookies["basket"];

            if (cookie == null)
            {
                basketVMs.Add(basketVM);
            }
            else
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
                if (basketVMs.Any(p => p.Id == id))
                {
                    basketVMs.FirstOrDefault(p => p.Id == id).Quantity += 1;
                }
                else
                {
                    basketVMs.Add(basketVM);
                }
            }
            string finalBasket = JsonConvert.SerializeObject(basketVMs);
            HttpContext.Response.Cookies.Append("basket", finalBasket);
            return Ok();
        }

        public IActionResult GetCookie()
        {
            string cookie = HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
            return Json(basketVMs);
        }

        
    }
}
