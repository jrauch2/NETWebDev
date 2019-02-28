using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Core.Models;

namespace Northwind.Core.Controllers
{
    public class HomeController : Controller
    {
        // this controller depends on the BloggingRepository
        private INorthwindRepository repository;
        public HomeController(INorthwindRepository repo) => repository = repo;

        public IActionResult Index() => View(repository.Categories.Include(c => c.Products).OrderBy(c => c.CategoryName).ToList());
    }
}
