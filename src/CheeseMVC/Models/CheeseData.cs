using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseData
    {
        static private List<Cheese> cheeses = new List<Cheese>();

        public static List<Cheese> GetAll()
        {
            return cheeses;
        }

        public static void Add(Cheese newCheese)
        {
            // Add the new cheese to my existing cheeses
            cheeses.Add(newCheese);
        }

        public static void Remove(int id)
        {
            Cheese cheeseToRemove = GetById(id);
            cheeses.Remove(cheeseToRemove);
        }

        public static Cheese GetById(int id)
        {
            return cheeses.Single(x => x.CheeseId == id);
        }
    }
}
