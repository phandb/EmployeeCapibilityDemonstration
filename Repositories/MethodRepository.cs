﻿using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.ViewModels.Method;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class MethodRepository :GenericRepository<Method>, IMethodRepository
    {
        private readonly ApplicationDbContext context;
        private readonly ICategoryRepository categoryRepository;


        // Initialize the DbContext via constructor
        public MethodRepository(ApplicationDbContext context,
                                ICategoryRepository categoryRepository) : base(context)
        {
            this.context = context;
            this.categoryRepository = categoryRepository;
        }


        public IEnumerable<SelectListItem> GetMethods()
        {
            var methods = new List<SelectListItem>();
            methods = (List<SelectListItem>)context.Methods
                .OrderBy(m => m.Name)
                .Select(m => new SelectListItem
                {
                    Value = m.MethodId,
                    Text = m.Name,
                }).ToList();

            var DefaultSelectedItem = new SelectListItem()
            {
                Value = null,
                Text = "--Select Method--"

            };

            methods.Insert(0, DefaultSelectedItem);

            return new SelectList(methods, "Value", "Text");
        }

        //   Methods
        /*
        public MethodViewModel CreateMethod()
        {
            var methodViewModel = new MethodViewModel()
            {
                Categories = (ICollection<SelectListItem>)categoryRepository.GetCategories()
            };

            return methodViewModel;
        }
        */

        public IEnumerable<SelectListItem> GetCategories()
        {
            List<SelectListItem> categories = (List<SelectListItem>)context.Categories
                .OrderBy(n => n.Name)
                .Select(n => new SelectListItem
                {
                    Value = n.CategoryId,
                    Text = n.Name
                }).ToList();
            var DefaultCategory = new SelectListItem()
            {
                Value = null,
                Text = "--Select Category--"
            };
            categories.Insert(0, DefaultCategory);

            return new SelectList(categories, "Value", "Text");
        }


        public ICollection<Category> GetCategoriesByMethod(string methodId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Method> GetEmployeesByMethod(string methodId)
        {
            throw new NotImplementedException();
        }

        
    }
}
