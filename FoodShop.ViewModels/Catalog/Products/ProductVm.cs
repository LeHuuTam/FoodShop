using FoodShop.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShop.ViewModels.Catalog.Products
{
    public class ProductVm
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }
        public List<string> Categories { get; set; } = new List<string>();
    }
}
