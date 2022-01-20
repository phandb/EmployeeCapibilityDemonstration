﻿using EmployeeCapibilityDemonstration.ViewModels.Category;
using EmployeeCapibilityDemonstration.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCapibilityDemonstration.ViewModels.Method
{
    public class MethodViewModel
    {
        public string Id { get; set; }
        [Key]
        public string? MethodId { get; set; }

        [Required]
        [Display(Name = "Method")]
        public string? Name { get; set; }

        public List<CategoryViewModel> CategoryVM { get; set; }
        public List<EmployeeDetailsViewModel> EmployeeDetails { get; set; }

        // Two fields provided for dropdown list. 
        // one for the selected item
        // One for the list which is made up of a collection of SelectListItem
        /*
        [Required, Display(Name = "Category")]
        public string SelectedCategory { get; set; }
        public ICollection<SelectListItem> Categories{ get; set; }

        */

    }
}
