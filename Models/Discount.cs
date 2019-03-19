using System;
using Northwind.Core.Models;

namespace Northwind.Core.Models
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public int Code { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ProductId { get; set; }
        public decimal DiscountPercent { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; }
    }
}