using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            CheeseListViewModel model = new CheeseListViewModel {
                Cheeses = CheeseData.GetAll()
            };

            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            // Add the new cheese to my existing cheeses
            CheeseData.Add(new Cheese(name, description));

            return Redirect("/");
        }

        public IActionResult Remove()
        {
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] cheeses)
        {
            foreach (int cheeseId in cheeses)
            {
                CheeseData.Remove(cheeseId);
            }

            return Redirect("/");
        }

        public IActionResult Detail(int id)
        {
            ViewBag.cheese = CheeseData.GetById(id);
            ViewBag.title = "Cheese Detail";
            return View();
        }

    }
}
