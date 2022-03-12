using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CategoryContext : DbContext
    {
        public CategoryContext():base("testapidb")
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Sale> sales { get; set; }

    }
    public class Product
    {
        
        public int Id { get; set; }

        public string Name{ get; set; }

        public string Price { get; set; }
        public ICollection<Sale> sales { get; set; }
    }
    public class Sale
    {

        public int Id { get; set; }

        public string qty { get; set; }

        public Product product { get; set; }
    }

}