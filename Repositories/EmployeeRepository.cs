using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        // Inject application Db Context
        private readonly ApplicationDbContext _context;

        // Constructor to initialize db context
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        // CRUD functionality
        public bool Create(Employee entity)
        {
            _context.Employees.Add(entity);
            return Save();
        }

        public bool Delete(Employee entity)
        {
            _context.Remove(entity);
            return Save();
        }

        public ICollection<Employee> FindAll()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }

        public Employee FindById(string id)
        {
            var employee = _context.Employees.Find(id);
            return employee;
        }

        public bool IsExisted(string id)
        {
            var exists = _context.Employees.Any(x => x.Id == id);
            return true;
        }


        public bool Update(Employee entity)
        {
            _context.Employees.Update(entity);
            return Save();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public ICollection<Employee> GetCategoriesByEmployee(string employeeId)
        {
            //var catgories = _context.Employees.
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetCategoriesByEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetMethodsByEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetMethodsByEmployee(string employeeId)
        {
            throw new NotImplementedException();
        }

    }
}
