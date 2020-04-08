using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horchateria.Models
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private double price;
        private string category;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }
    }
}
