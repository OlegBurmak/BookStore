using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBookStore.Models;
using TheBookStore.Models.ViewModels;

namespace TheBookStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IProductRepository repository;

        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            ViewBag.SelectedLanguage = RouteData?.Values["language"];
            ViewBag.SelectedAge = RouteData?.Values["age"];
            return View(new NavigationMenuViewModel
            {
                Category = repository.Products.Select(c => c.Category).Distinct().OrderBy(c => c),
                Language = repository.Products.Select(l => l.Language).Distinct().OrderBy(l => l),
                Age = repository.Products.Select(a => a.Age).Distinct().OrderBy(a => a)
            }
            );
        }

    }
}
