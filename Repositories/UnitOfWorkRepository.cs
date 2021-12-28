using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly ApplicationDbContext _context;
        private IEmployeeRepository _employeeRepo;
        private IMethodRepository _methodRepo;
        private ICategoryRepository _categoryRepo;


        public UnitOfWorkRepository(ApplicationDbContext context)

        {
            _context = context;

        }
        public IEmployeeRepository Employee => _employeeRepo = _employeeRepo ?? new EmployeeRepository(_context);
        
        public IMethodRepository Method
        {
            get
            {
                return _methodRepo = _methodRepo ?? new MethodRepository(_context, _categoryRepo);   
            }
        }
        

        public ICategoryRepository Category
        {
            get
            {
                return _categoryRepo = _categoryRepo ?? new CategoryRepository(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
