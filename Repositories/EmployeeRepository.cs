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

        public Task AddAsync(EmployeeMethod methodAdded)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeAddMethodViewModel> PopulateMethodsDropDownList()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            var model = new EmployeeAddMethodViewModel()
            {
                EmployeeId = user.Id,
                Methods = methodRepo.GetMethods(),
            };
            return model;
        }
        public async Task<EmployeeDetailsViewModel> GetEmployeeDetail()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            // if (employee == null)  return null;

            var employee = await context.Employees
                                    .Include(e => e.EmployeeMethods)
                                        .ThenInclude(m => m.Method)
                                        .SingleOrDefaultAsync(m => m.Id == user.Id);

            var employeeMethodModel = mapper.Map<EmployeeDetailsViewModel>(user);
            employeeMethodModel.Methods = mapper.Map<List<MethodViewModel>>(employee.EmployeeMethods);

                // Categories = mapper.Map<List<CategoryViewModel>>(methods)                        
            
            

            return employeeMethodModel;
        }

        public async Task<EmployeeDetailsViewModel> GetEmployeeMethods(string employeeId)
        {
            var employee = await userManager.FindByIdAsync(employeeId);
           
            var methods = await context.Methods.Include(m => m.EmployeeMethods)
                                          .ThenInclude(em => em.Employee)
                                          .ToListAsync();                        
               

            var employeeMethodModel = mapper.Map<EmployeeDetailsViewModel>(employee);
           // employeeMethodModel.Methods = mapper.Map<List<MethodViewModel>>(methods);
           

            return employeeMethodModel;
        }

    }
}
