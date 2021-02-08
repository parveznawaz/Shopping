using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new Product()
            {
                Name = "IPhone X",
                Description = "This phone is best phone from Apple",
                ImageFile = "product-1.jpg",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Name = "Samsung 10",
                Description = "This phone is best phone from Samsung",
                ImageFile = "product-2.jpg",
                Price = 900.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Name = "LG 123",
                Description = "This phone is best phone from LG",
                ImageFile = "product-3.jpg",
                Price = 400.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Name = "HTC Q",
                Description = "This phone is best phone from HT4",
                ImageFile = "product-2.jpg",
                Price = 300.00M,
                Category = "Smart Phone"
            }

        };
    }
}
