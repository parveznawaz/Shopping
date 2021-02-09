using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Data
{
    public class ProductContext
    {
        public IMongoCollection<Product> Products { get; }

        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
            Products = database.GetCollection<Product>(configuration["DatabaseSettings:Collectionname"]);
            SeedData(Products);
        }

        private static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product>() {
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




        //public static readonly List<Product> Products = new List<Product>()
        //{
        
        //};
    }
}
