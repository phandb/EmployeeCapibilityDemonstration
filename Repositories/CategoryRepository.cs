﻿using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        // Its own method

        public ICollection<Category> GetEmployeesByCategory(string categoryId)
        {
            throw new NotImplementedException();
        }

    }
}
