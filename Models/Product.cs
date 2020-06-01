using System;

namespace TheBookStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int Age { get; set; }
        public string Author { get; set; }
        public string Size { get; set; }
        public int PageCount { get; set; }
        public double Rate { get; set; }
        public DateTime DateCreate { get; set; }
        public string Image { get; set; }

    }
}
