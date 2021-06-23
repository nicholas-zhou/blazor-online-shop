using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Men's Brooklyn Nets Kyrie Irving 2021/21 Swingman Jersey - Earned Edition",
                    Description = "Kyrie Irving",
                    Image = "https://fanatics.frgimages.com/FFImage/thumb.aspx?i=/productimages/_3959000/altimages/ff_3959320-2ed432ba2747ad1301c7alt1_full.jpg&w=900",
                    Price = 129.99m,
                    OriginalPrice = 129.99m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Barney Stinson Funko Pop",
                    Description = "\"A lie is a great story that someone ruined with the truth.\"",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/71O8tasNapL._AC_SX522_.jpg",
                    Price = 5.99m,
                    OriginalPrice = 12.99m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Harry Potter Books 1-7",
                    Description = "HARRY POTTER BOXED SET 1-7 includes the seven phenomenal Harry Potter hardcover books by best selling author J. K. Rowling. These books are housed in a collectible trunk-like box with sturdy handles and privacy lock. Bonus decorative stickers are included in each boxed set.",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51qOOVlgR+L._SX258_BO1,204,203,200_.jpg",
                    Price = 132.99m,
                    OriginalPrice = 140.50m
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Men's Utah Jazz Donovan Mitchell 2019/20 Swingman Jersey - Hardwood Classic",
                    Description = "Donovan Mitchell",
                    Image = "https://cdn11.bigcommerce.com/s-2hny161y9r/images/stencil/800x800/products/9760/4282/AV4517-504-PHSFH001-NDS-A__45923.1617054139.png?c=2",
                    Price = 110.00m,
                    OriginalPrice = 130.00m
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Scarlet Witch Funko Pop",
                    Description = "",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/71B5ZJfz55L._AC_SY355_.jpg",
                    Price = 10.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Skulduggery Pleasant Books 1-9",
                    Description = "Skulduggery pleasant book set by Derek Landy is one of the best fantasy series designed for young readers. The series contains 9 brilliant titles. Skulduggery Pleasant, Playing with Fire, The Faceless Ones, Dark Days, Mortal Coil, Death Bringer, Kingdom of the Wicked, Last Stand of Dead Men, The Dying of the Light.",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61fcLl3U3jL._SX489_BO1,204,203,200_.jpg",
                    Price = 33.99m,
                    OriginalPrice = 33.99m
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 1,
                    Title = "Men's Atlanta Hawks Kevin Huerter 2020/21 Swingman Jersey - Statement Edition",
                    Description = "Kevin Huerter",
                    Image = "https://img.btdmp.com/10206/10206816/products/0x900@1623226240a07579565c.jpeg",
                    Price = 139.99m,
                    OriginalPrice = 139.99m
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Pikachu Funko Pop",
                    Description = "",
                    Image = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcSU4s5Gz9CdwtcAR9gL6c46x_4uwrYkurUDfUK3tcegKuoRNU6L&usqp=CAY",
                    Price = 11.00m,
                    OriginalPrice = 11.00m
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "A Song of Ice and Fire Books 1-5",
                    Description = "An immersive entertainment experience unlike any other, A Song of Ice and Fire has earned George R. R. Martin—dubbed “the American Tolkien” by Time magazine—international acclaim and millions of loyal readers.",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61iRBvRYEcL._SY498_BO1,204,203,200_.jpg",
                    Price = 26.93m,
                    OriginalPrice = 49.95m
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 4,
                    Title = "Vincenzo Poster",
                    Description = "\"Regret is the most painful thing in life.\"",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61PTG7XW66S._AC_SX425_.jpg",
                    Price = 17.95m,
                    OriginalPrice = 17.95m
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 4,
                    Title = "A Quiet Place Part II Poster",
                    Description = "",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61JsK4wY-9S._AC_SX425_.jpg",
                    Price = 12.00m,
                    OriginalPrice = 12.00m
                },
                new Product
                {
                    Id = 12,
                    CategoryId = 4,
                    Title = "Stranger Things Season 3 Poster",
                    Description = "",
                    Image = "https://cdn.europosters.eu/image/750/posters/stranger-things-one-summer-i70046.jpg",
                    Price = 9.99m,
                    OriginalPrice = 12.99m
                },
            };
    }
}
