using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class MethodRepository :GenericRepository<Method>, IMethodRepository
    {
        private readonly ICategoryRepository categoryRepository;


        // Initialize the DbContext via constructor
        public MethodRepository(ApplicationDbContext context,
                                ICategoryRepository categoryRepository) : base(context)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> GetCategories()
        {
            var categories = await categoryRepository.GetAllAsync();
            return categories;
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
