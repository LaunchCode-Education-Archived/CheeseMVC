using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseData
    {

        static private List<Cheese> Cheeses = new List<Cheese>();

        public static List<Cheese> GetAll()
        {
            return Cheeses;
        }

        public static Cheese GetById(int cheeseId)
        {
            return Cheeses.Single(x => x.CheeseId == cheeseId);
        }

        public static void Add(Cheese newCheese)
        {
            Cheeses.Add(newCheese);
        }

        public static bool Remove(int cheeseId)
        {
            return Cheeses.Remove(GetById(cheeseId));
        }
    }
}
