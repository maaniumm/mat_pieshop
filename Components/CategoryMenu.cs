﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;

namespace PieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cat = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(cat);
        }
    }
}
