using azen.Data;
using azen.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azen.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmProduct model = new VmProduct();
            model.Products = _context.Products
                                     .Include("ProductImages")
                                     .Include(c=>c.SizeToProducts)
                                     .ThenInclude(cs=>cs.ColorToSizeToProducts).ToList();

            string oldData = Request.Cookies["cart"];
            if (!string.IsNullOrEmpty(oldData))
            {
                model.Cart = oldData.Split("-").ToList();
            }
            return View(model);
        }

        public IActionResult AddToCart(int id)
        {
            string oldData = Request.Cookies["cart"];
            string newData = null;

            if (string.IsNullOrEmpty(oldData))
            {
                newData = id.ToString();
            }
            else
            {
                List<string> cartArr = oldData.Split("-").ToList();
                if (cartArr.Any(a => a == id.ToString()))
                {
                    cartArr.Remove(id.ToString());
                    newData = string.Join("-", cartArr);
                }
                else
                {
                    newData = oldData + "-" + id;
                }
            }


            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(1)
            };
            Response.Cookies.Append("cart", newData, options);

            return RedirectToAction("index");
        }

        public IActionResult Cart()
        {
            return View();
        }

    }
}
