using System;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        

        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public AddCategoryViewModel()
        {

        }
    }
}
