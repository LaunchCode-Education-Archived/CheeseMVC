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

        [Range(1,5,ErrorMessage ="Rating must be between 1 and 5")]
        public int Rating { get; set; }

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        public AddCheeseViewModel() {

            CheeseTypes = new List<SelectListItem>();

            var values = Enum.GetValues(typeof(CheeseType));

            foreach (var value in values)
            {
                CheeseTypes.Add(new SelectListItem
                {
                    Value = ((int)value).ToString(),
                    Text = value.ToString()
                });
            }
        }

        public Cheese CreateCheese()
        {
            return new Cheese {
                Name = this.Name,
                Description = this.Description,
                Type = this.Type,
                Rating = this.Rating
            };
        }
    }
}
