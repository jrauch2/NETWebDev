using System;
using System.Linq;
using Northwind.Core.Models;

namespace Northwind.Core.Models
{
    public interface INorthwindRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Product> Products { get; }
        IQueryable<Discount> Discounts { get; }

        // TODO: AddBlog, UpdateBlog, DeleteBlog
        // TODO: AddPost, UpdatePost, DeletePost
    }
}