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
    }
}
