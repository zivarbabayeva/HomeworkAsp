using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZivarHomework.DAL;
using ZivarHomework.ViewModels;

namespace ZivarHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Categories = _context.Categories.ToList(),
                Products =_context.Products.Include(p => p.Category).Take(8).ToList(),
                About= _context.About.FirstOrDefault()
            };
            return View(homeVM);
        }
    }
}
