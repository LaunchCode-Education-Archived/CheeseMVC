using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(CheeseData.GetAll());
        }

        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();

            return View(addCheeseViewModel);
        }

        [HttpPost]
        // Add(Cheese newCheese)
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            if (ModelState.IsValid)
            {
                Cheese newCheese = new Models.Cheese
                {
                    Name = addCheeseViewModel.Name,
                    Description = addCheeseViewModel.Description,
                    Type = addCheeseViewModel.Type
                };

                CheeseData.Add(newCheese);

                return Redirect("/");
            }

            return View(addCheeseViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }

            return Redirect("/");
        }
    }
}
