using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseComparer : IComparer<Cheese>
    {
        public int Compare(Cheese x, Cheese y)
        {
            return x.Rating - y.Rating;
        }
    }
}
