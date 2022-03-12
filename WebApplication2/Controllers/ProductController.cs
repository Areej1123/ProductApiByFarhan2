using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
  [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        CategoryContext db = new CategoryContext();

        [Route("getall")]
        [HttpGet]
        public List<Product> product()
        {
            return db.products.ToList();
        }
        [Route("add")]
        [HttpPost]
        public string product(Product product)
        {
            db.products.Add(product);
            db.SaveChanges();
            return "Add Successfully";
        }
        [Route("get/{id}")]
        [HttpGet]
        public Product product(int id)
        {
            Product product = db.products.Find(id);
            if (product != null)
            {
                return
                    product;
            }
            else
            {
                return null;
            }
        }
        [Route("del/{id}")]
        [HttpDelete]
        public string productdel(int id)
        {
            Product product = db.products.Find(id);
            if(product!=null)
            {
                db.products.Remove(product);
                db.SaveChanges();
                return "Deleted Successfully";
            }
            else
            {
                return "Data No found";
            }
        }
        [Route("update/{id}")]
        [HttpPut]
        public string product(Product newproduct,int id)
        {
            Product product = db.products.Find(id);
            product.Name = newproduct.Name;
            product.Price = newproduct.Price;
            db.SaveChanges();
            return "update Successfully";
        }
    }
}
