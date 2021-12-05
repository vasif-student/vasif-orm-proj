using Microsoft.AspNetCore.Mvc;
using ORM_project.Data;
using ORM_project.Models;
using ORM_project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_project.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext _context;

        public HomeController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel { Users = _context.Users.ToList(), Products = _context.Products.ToList(), Orders = _context.Orders.ToList(), Categories = _context.Categories.ToList() };
            return View(model);
        }

        public IActionResult Product()
        {
            var model = new HomeIndexViewModel { Users = _context.Users.ToList(), Products = _context.Products.ToList(), Orders = _context.Orders.ToList(), Categories = _context.Categories.ToList() };
            return View(model);
        }
    }
}
