using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBookStore.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> TopProducts { get; set; }
        public IEnumerable<Product> NewProducts { get; set; }
        public IEnumerable<Product> TopDayProducts { get; set; }
    }
}
