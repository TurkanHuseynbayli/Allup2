using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Allup1.Models;
using Allup1.DAL;
using Allup1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Allup1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Categories = _context.Categories.Where(ct => ct.IsMain == true && ct.IsDeleted == false).ToList(),
                Products = _context.Products.Where(pr => pr.IsDeleted == false).Include(pro => pro.Images).ToList(),
                ProductCategories = _context.ProductCategories.Where(prCt => prCt.Category.IsDeleted == false &&
                prCt.Product.IsDeleted == false).ToList(),
                ProductImages = _context.ProductImages.Include(p => p.Product).ToList()
            };
            return View(homeVM);
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
