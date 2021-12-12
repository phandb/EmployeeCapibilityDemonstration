using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        //  Inject the DbContext
        private readonly ApplicationDbContext _context;

        // Use constructor to initialize the Db context
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        // CRUD to database
        public bool Create(Category entity)
        {
            _context.Categories.Add(entity);
            return Save();
        }

        public bool Delete(Category entity)
        {
            _context.Categories.Remove(entity);
            return Save();
        }

        public ICollection<Category> FindAll()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }

        public Category FindById(string id)
        {
            var category = _context.Categories.Find(id);
            return category;
        }


        public bool IsExisted(string id)
        {
            var exists = _context.Categories.Any(c => c.CategoryId == id);
            return exists;
        }


        public bool Update(Category entity)
        {
            _context.Categories.Update(entity);
            return Save();
        }


        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public ICollection<Category> GetEmployeesByCategory(string categoryId)
        {
            throw new NotImplementedException();
        }

    }
}
