using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBookStore.Models.ViewModels
{
    public class StoreListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentLanguage { get; set; }
        public int CurrentAge { get; set; }
        public string CurrentCategory { get; set; }
    }
}
