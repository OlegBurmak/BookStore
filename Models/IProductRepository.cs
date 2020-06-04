using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBookStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void SaveComment(Product product);
    }
}
