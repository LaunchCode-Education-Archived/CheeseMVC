using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private int CheeseId;

        public Cheese(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
