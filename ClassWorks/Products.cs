using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWorks
{
    public class Products
    {
        public List<Product> ProductList => new List<Product> {
            new Product { Name = "Chai", Price = 18.00m },
            new Product { Name = "Chang", Price = 19.00m },
            new Product { Name = "Aniseed Syrup", Price = 10.00m },
            new Product { Name = "Chef Anton’s Cajun Seasoning", Price = 22.00m },
            new Product { Name = "Chef Anton’s Gumbo Mix", Price = 21.35m },
            new Product { Name = "Grandma’s Boysenberry Spread", Price = 25.00m },
            new Product { Name = "Uncle Bob’s Organic Dried Pears", Price = 30.00m },
            new Product { Name = "Northwoods Cranberry Sauce", Price = 40.00m },
            new Product { Name = "Mishi Kobe Niku", Price = 97.00m },
            new Product { Name = "Ikura", Price = 31.00m }
        };
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
