using System;
using System.Linq;
using Northwind.Core.Models;

namespace Northwind.Core.Models
{
    public class EFNorthwindRepository : INorthwindRepository
    {
        // the repository class depends on the BloggingContext service
        // which was registered at application startup
        private NorthwindContext context;
        public EFNorthwindRepository(NorthwindContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Category> Categories => context.Categories;
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Discount> Discounts => context.Discounts;

    }
}