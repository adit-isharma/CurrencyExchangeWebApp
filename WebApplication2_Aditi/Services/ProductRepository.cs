using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2_Aditi.Models;

namespace WebApplication2_Aditi.Services
{
    public class ProductRepository
    {
        public List<Product> GetAllProducsts()
        {
            List<Product> product = new List<Product>();
            
            product =  new List<Product>
            {
                new Product
                {
                    name = "T-shirt",
                    description = "Men's tshirt, size medium",
                    price = 19.99
                },
                new Product
                {
                    name = "Jeans",
                    description = "Women jeans, size small",
                    price = 45.99
                },
                new Product
                {
                    name = "Hat",
                    description = "Summer Hat, One Size",
                    price = 45.99
                },
                new Product
                {
                    name = "Coat",
                    description = "Unisex Winter Jacker, Size Large",
                    price = 45.99
                },
                new Product
                {
                    name = "Trainers",
                    description = "Women Fashion Footwear, size 37",
                    price = 45.99
                }
            };
            return product;
        }
    }
}