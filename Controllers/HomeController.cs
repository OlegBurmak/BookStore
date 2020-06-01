using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheBookStore.Models;
using TheBookStore.Models.ViewModels;

namespace TheBookStore.Controllers
{
    public class HomeController : Controller
    {

        private IProductRepository repository;


        public HomeController(IProductRepository repo)
        {
            repository = repo;   
        }

        public ViewResult Index(string category) =>
            View(new ProductListViewModel
            {
                TopProducts = repository.Products.OrderByDescending(p => p.Rate).Take(3),
                NewProducts = repository.Products.Where(p => (DateTime.UtcNow.Day - p.DateCreate.Day) <= 7 )
                                                .OrderBy(p => p.DateCreate).Take(10),
                TopDayProducts = repository.Products.Where(p => (DateTime.UtcNow.Day - p.DateCreate.Day) <= 1)
                                                .OrderByDescending(p => p.Rate).Take(10)
                //.Where(p => category == null || p.Category == category)
            });
    }
}
