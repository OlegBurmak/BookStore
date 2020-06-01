using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBookStore.Models;
using TheBookStore.Models.ViewModels;

namespace TheBookStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 11;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, string language, int? age, int productPage = 1) => View(new StoreListViewModel
        { 
            Products = repository.Products.Where(p => category == null || p.Category == category)
                    .Where(l => language == null || l.Language == language)
                    .Where(a => age == null || a.Age <= age)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                repository.Products.Count() :
                repository.Products.Where(e => e.Category == category).Count()
            },
            CurrentCategory = category
            
        });

        public ViewResult PageProduct(int productId)
        {
            Product prod = repository.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            return View(prod);
        }
    }
}