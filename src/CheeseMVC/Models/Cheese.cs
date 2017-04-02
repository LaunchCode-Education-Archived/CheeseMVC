using System;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }

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
    }
}
