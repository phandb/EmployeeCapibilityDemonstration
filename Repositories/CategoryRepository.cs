using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        // Its own method

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

        public ICollection<Category> GetEmployeesByCategory(string categoryId)
        {
            throw new NotImplementedException();
        }

    }
}
