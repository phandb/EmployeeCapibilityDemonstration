using AutoMapper;
using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.ViewModels.Category;
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
        private readonly IHttpContextAccessor httpContextAccessor;





        // Constructor to initialize db context
        public EmployeeRepository(ApplicationDbContext context,
                                  IMethodRepository methodRepo,
                                  ICategoryRepository categoryRepo,
                                  IMapper mapper,
                                  UserManager<Employee> userManager,
                                  IHttpContextAccessor httpContextAccessor) : base(context)
        {
            this.context = context;
            this.methodRepo = methodRepo;
            this.categoryRepo = categoryRepo;
            this.mapper = mapper;
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<EmployeeDetailsViewModel> GetEmployeeDetail()
        {
            var employee = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            // if (employee == null)  return null;

            var methods =  await context.Methods.Include(m => m.EmployeeMethods)
                                         .ThenInclude(em => em.Employee)
                                         .ToListAsync();
           
            var model = new EmployeeDetailsViewModel
            {
                EmployeeId = employee.Id,
                Email = employee.Email,
                firstName = employee.FirstName,
                lastName = employee.LastName,
                dateHired = employee.HiredDate,
                EmployeeHasMethods = mapper.Map<List<MethodViewModel>>(methods)
            };

            return model;
        }

        public async Task<EmployeeDetailsViewModel> GetEmployeeMethods(string employeeId)
        {
            var employee = await userManager.FindByIdAsync(employeeId);
           
            var methods = await context.Methods.Include(m => m.EmployeeMethods)
                                          .ThenInclude(em => em.Employee)
                                          .ToListAsync();                        
                                            
                                                        
            var categories = await context.Categories.Include(c => c.EmployeeCategories)
                                                .ThenInclude(ec => ec.Employee)
                                                .ToListAsync();
                   
                      

            var employeeMethodModel = mapper.Map<EmployeeDetailsViewModel>(employee);
            employeeMethodModel.EmployeeHasMethods = mapper.Map<List<MethodViewModel>>(methods);
            employeeMethodModel.MethodCategories = mapper.Map<List<CategoryViewModel>>(categories);

            return employeeMethodModel;
        }

    }
}
