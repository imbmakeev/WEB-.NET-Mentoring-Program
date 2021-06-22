using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NorthwindApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NorthwindApp.ViewModels;

namespace NorthwindApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; //Реализация в последующих заданиях

        private AppDataContext db;


        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(AppDataContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Products()
        {
            var products = await db.Products.Include(c => c.Category).Include(s=>s.Supplier)
            .Select(p => new ProductViewModel
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                QuantityPerUnit = p.QuantityPerUnit,
                UnitPrice = p.UnitPrice,
                UnitsInStock = p.UnitsInStock,
                UnitsOnOrder = p.UnitsOnOrder,
                ReorderLevel = p.ReorderLevel,
                Discontinued = p.Discontinued,
                CategoryName = p.Category.CategoryName,
                SupplierName= p.Supplier.CompanyName
            }
            ).ToListAsync();


            return View(products);
        }

        public async Task<IActionResult> Categories()
        {
            return View(await db.Categories.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
