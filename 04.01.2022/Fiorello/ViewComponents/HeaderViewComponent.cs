using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public HeaderViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string cookie = HttpContext.Request.Cookies["basket"];
            if (cookie != null)
            {
                double sum = 0;
                List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
                ViewBag.BasketCount = basketVMs.Count();
                foreach (BasketVM item in basketVMs)
                {
                    Product product = _db.Products.FirstOrDefault(p => p.Id == item.Id);
                    sum += product.Price * item.Quantity;
                }
                ViewBag.TotalPrice = sum;
            }
            Setting model = await _db.Settings.FirstOrDefaultAsync();
            return View(await Task.FromResult(model));
        }
    }




}
