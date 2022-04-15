using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _db;
        public BasketController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            string cookie = HttpContext.Request.Cookies["basket"];
            List<BasketVM> model = new List<BasketVM>();
            if (cookie != null)
            {
                List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
                foreach (BasketVM item in basketVMs)
                {
                    Product product = _db.Products.FirstOrDefault(p => p.Id == item.Id);
                    model.Add(new BasketVM
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        Image = product.Image,
                        Quantity = item.Quantity,
                        Subtotal = item.Quantity * product.Price
                    });
                }
            }


            return View(model);
        }

        public object UpdateNavCart()
        {
            int count = 0;
            double sum = 0;
            string cookie = HttpContext.Request.Cookies["basket"];
            if (cookie != null)
            {
                List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
                count = basketVMs.Count();
                foreach (BasketVM item in basketVMs)
                {
                    Product product = _db.Products.FirstOrDefault(p => p.Id == item.Id);
                    sum += product.Price * item.Quantity;
                }
            }

            return new
            {
                count,
                sum
            };
        }

        public async Task<IActionResult> RemoveItem(int? id)
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
            string cookie = HttpContext.Request.Cookies["basket"];
            List<BasketVM> model = new List<BasketVM>();
            if (cookie != null)
            {
                List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
                if (!basketVMs.Any(p => p.Id == id))
                {
                    return BadRequest();
                }
                basketVMs.Remove(basketVMs.FirstOrDefault(p => p.Id == id));
                foreach (BasketVM item in basketVMs)
                {
                    Product prod = _db.Products.FirstOrDefault(p => p.Id == item.Id);
                    model.Add(new BasketVM
                    {
                        Id = prod.Id,
                        Name = prod.Name,
                        Price = prod.Price,
                        Image = prod.Image,
                        Quantity = item.Quantity,
                        Subtotal = item.Quantity * prod.Price
                    });
                }
                string finalBasket = JsonConvert.SerializeObject(basketVMs);
                HttpContext.Response.Cookies.Append("basket", finalBasket);
            }
            return PartialView("_CartPartial", model);
        }
    }
}
