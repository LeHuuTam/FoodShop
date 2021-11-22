﻿using FoodShop.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll();
    }
}
