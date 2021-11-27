using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class MethodRepository : IMethodRepository
    {
        // Inject DbContext
        private readonly ApplicationDbContext _context;

        // Initialize the DbContext via constructor
        public MethodRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(Method entity)
        {
            _context.Methods.Add(entity);
            return Save();
        }

        public bool Delete(Method entity)
        {
            _context.Methods.Remove(entity);
            return Save();
        }

        public ICollection<Method> FindAll()
        {
            var methods = _context.Methods.ToList();
            return methods;
        }

        public Method FindById(string id)
        {
            var method = _context.Methods.Find(id);
            return method;
        }

        public bool IsExisted(string id)
        {
            var exists = _context.Methods.Any(m => m.MethodId == id);
            return exists;  
        }


        public bool Update(Method entity)
        {
            _context.Methods.Update(entity);
            return Save();
        }


        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public ICollection<Method> GetEmployeesByMethod(string methodId)
        {
            throw new NotImplementedException();
        }

    }
}
