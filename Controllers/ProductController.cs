using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EShoppingApp.Models;

namespace EShoppingApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Wireless Headphones", Description = "Noise-cancelling over-ear headphones.", Price = 149.99m, ImageUrl = "https://via.placeholder.com/300x200" },
                new Product { Id = 2, Name = "Smart Watch", Description = "Track your fitness and notifications.", Price = 99.99m, ImageUrl = "https://via.placeholder.com/300x200" },
                new Product { Id = 3, Name = "Gaming Laptop", Description = "High-performance laptop for gaming.", Price = 1099.99m, ImageUrl = "https://via.placeholder.com/300x200" },
                new Product { Id = 4, Name = "Bluetooth Speaker", Description = "Portable and powerful speaker.", Price = 49.99m, ImageUrl = "https://via.placeholder.com/300x200" },
                new Product { Id = 5, Name = "4K TV", Description = "Ultra HD Smart TV with HDR.", Price = 599.99m, ImageUrl = "https://via.placeholder.com/300x200" },
                new Product { Id = 6, Name = "Smartphone", Description = "Latest smartphone with advanced features.", Price = 799.99m, ImageUrl = "https://via.placeholder.com/300x200" }
            };

            return View(products);
        }
    }
}

