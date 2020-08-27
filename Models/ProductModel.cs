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
                    Name = "Name 1",
                    Price = 5,
                    Photo = "thumb1.gif"
                },
                new Product
                {
                    Id = 002,
                    Name = "Name 2",
                    Price = 2,
                    Photo = "thumb2.gif"
                },
                new Product
                {
                    Id = 003,
                    Name = "Name 3",
                    Price = 6,
                    Photo = "thumb3.gif"
                }
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