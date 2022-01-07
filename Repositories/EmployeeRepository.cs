using AutoMapper;
using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.ViewModels.Employee;
using EmployeeCapibilityDemonstration.ViewModels.Method;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        // Inject application Db Context
        private readonly ApplicationDbContext context;
        private readonly IMethodRepository methodRepo;
        private readonly ICategoryRepository categoryRepo;
        private readonly IMapper mapper;
        private readonly UserManager<Employee> userManager;





        // Constructor to initialize db context
        public EmployeeRepository(ApplicationDbContext context,
                                  IMethodRepository methodRepo,
                                  ICategoryRepository categoryRepo,
                                  IMapper mapper,
                                  UserManager<Employee> userManager) : base(context)
        {
            this.context = context;
            this.methodRepo = methodRepo;
            this.categoryRepo = categoryRepo;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<EmployeeDetailsViewModel> GetEmployeeMethods(string employeeId)
        {
            var employee = await userManager.FindByIdAsync(employeeId);
            var methods = context.Methods.Include(e => e.EmployeeMethods)
                                         .ThenInclude(e => e.Employee)
                                         .ToListAsync();                        
                                               
                                                        
            var categories = context.Categories.Include(c => c.EmployeeCategories)
                                                .ToListAsync();
                            

            

            var employeeMethodModel = mapper.Map<EmployeeDetailsViewModel>(employee);
           // employeeMethodModel.EmployeeHasMethods = mapper.Map<List<MethodViewModel>>(methods);
            return employeeMethodModel;
        }

    }
}
