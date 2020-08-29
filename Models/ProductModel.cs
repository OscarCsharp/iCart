using iCart.Enteties ;
using System.Collections.Generic;
using System.Linq;

namespace iCart.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>() {
                new Product
                {
                    Id = 001,
                    Name = "Soft Drink",
                    Price = 20,
                    Photo = "colddrink.png"
                },
                new Product
                {
                    Id = 002,
                    Name = "Pizza",
                    Price = 120,
                    Photo = "pizza.png"
                },
                new Product
                {
                    Id = 003,
                    Name = "Meat",
                    Price = 250,
                    Photo = "meat.jpg"
                },
                /*new Product
                {
                    Id = 004,
                    Name = "Burger",
                    Price = 50,
                    Photo = "burger.jpg"
                },
                new Product
                {
                    Id = 005,
                    Name = "Alcholo 6 Pack",
                    Price = 250,
                    Photo = "alcohol.png"
                },
                new Product
                {
                    Id = 003,
                    Name = "Vegies",
                    Price = 20,
                    Photo = "veg.png"
                }*/
            };
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(int id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }
    }
}