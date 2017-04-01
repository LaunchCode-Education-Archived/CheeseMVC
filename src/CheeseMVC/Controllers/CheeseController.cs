using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using System.Collections.Generic;
using CheeseMVC.ViewModels;
using System.Collections;
using CheeseMVC.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        private readonly CheeseDbContext context;

        public CheeseController(CheeseDbContext dbContext)
        {
            this.context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Cheese> cheeses = context.Cheeses.ToList();

            return View(cheeses);
        }

        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();
            return View(addCheeseViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Add the new cheese to my existing cheeses
                    Cheese newCheese = addCheeseViewModel.CreateCheese();
                    context.Cheeses.Add(newCheese);
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    addCheeseViewModel.SaveChangesError = "Save failed. Try again.";
                    return View(addCheeseViewModel);
                }

                return Redirect("/Cheese");
            }

            return View(addCheeseViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = context.Cheeses.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] cheeseIds)
        {
            
            foreach (int cheeseId in cheeseIds)
            {
                Cheese toRemove = context.Cheeses.Single(c => c.ID == cheeseId);
                context.Cheeses.Remove(toRemove);
            }
            context.SaveChanges();
            

            return Redirect("/");
        }
    }
}
