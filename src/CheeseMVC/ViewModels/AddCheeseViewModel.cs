using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }


        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public List<SelectListItem> Categories { get; set; }

     

        public AddCheeseViewModel(IEnumerable<CheeseCategory> cat)
        {
            Categories = new List<SelectListItem>();

            foreach (CheeseCategory category in cat)
            {
                this.Categories.Add(new SelectListItem()
                {
                    Value = category.ID.ToString(),
                    Text = category.Name
                });


                //Categories= new List<SelectListItem>();

                //// <option value="0">Hard</option>
                //Categories.Add(new SelectListItem {
                //    Value = ((int) Categories.Hard).ToString(),
                //    Text = Categories.Hard.ToString()
                //});

                //CheeseTypes.Add(new SelectListItem
                //{
                //    Value = ((int)CheeseType.Soft).ToString(),
                //    Text = CheeseType.Soft.ToString()
                //});

                //CheeseTypes.Add(new SelectListItem
                //{
                //    Value = ((int)CheeseType.Fake).ToString(),
                //    Text = CheeseType.Fake.ToString()
                //});

            }


        }

        public AddCheeseViewModel() { }
        // empty constructor 

    }
}