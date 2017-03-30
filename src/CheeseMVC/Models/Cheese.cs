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
        public CheeseType Type { get; set; }

        private int rating;
        public int Rating {
            get { return rating; }
            set {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException("Rating must be between 1 and 5");
                }

                rating = value;
            }
        }

        public int CheeseId { get; set; }
        private static int nextId = 1;

        public Cheese()
        {
            CheeseId = nextId;
            nextId++;
        }
    }
}
