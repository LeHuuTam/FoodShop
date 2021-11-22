using FoodShop.Data.EF;
using FoodShop.ViewModels.Catalog.Categories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly FoodShopDbContext _context;

        public CategoryService(FoodShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryVm>> GetAll()
        {
            var query = from c in _context.Categories
                        select new { c};
            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.c.Name
            }).ToListAsync();
        }
    }
}
