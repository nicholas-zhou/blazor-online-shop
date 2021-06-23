using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category> {
                new Category { Id = 1, Name = "Jerseys", Url = "jerseys", Icon = "fire"},
                new Category { Id = 2, Name = "Funko Pops", Url = "funko-pops", Icon = "box"},
                new Category { Id = 3, Name = "Books", Url = "books", Icon = "book"},
                new Category { Id = 4, Name = "Posters", Url = "posters", Icon = "image"},
            };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
