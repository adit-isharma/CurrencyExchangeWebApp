using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication2_Aditi.Models;
using WebApplication2_Aditi.Services;

namespace WebApplication2_Aditi.Controllers
{
    public class ProductController : ApiController
    {
        public ProductRepository productRepository;

        public ProductController()
        {
            this.productRepository = new ProductRepository();
        }
        // GET: Product
        [System.Web.Http.HttpGet]
        public string Get()
        {
            var products = this.productRepository.GetAllProducsts();
            //return products.ToList();
            var json = JsonConvert.SerializeObject(products);
            return json;
        }
    }
}