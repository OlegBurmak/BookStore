using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBookStore.Models.ViewModels
{
    public class NavigationMenuViewModel
    {
        public IEnumerable<string> Category { get; set; }
        public IEnumerable<string> Language { get; set; }
        public IEnumerable<int> Age { get; set; }
    }
}
