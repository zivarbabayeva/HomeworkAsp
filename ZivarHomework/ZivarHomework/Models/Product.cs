using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZivarHomework.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
} 
