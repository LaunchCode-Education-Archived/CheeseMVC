using CheeseMVC.Models;
using System.Collections.Generic;

namespace CheeseMVC.ViewModels
{
    public class AllCheesesViewModel
    {
        public List<Cheese> Cheeses { get; set; }

        public AllCheesesViewModel()
        {
            Cheeses = CheeseData.GetAll();
        }
    }
}
