using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheBookStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext appContext)
        {
            context = appContext;
        }
        public IQueryable<Product> Products => context.Products.Include(c => c.Comments); 
        
        public void SaveComment(Product product)
        {
            context.AttachRange(product.Comments);
            context.SaveChanges();
        }
    }
}
