using AutoMapper;
using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;
using Microsoft.AspNetCore.Identity;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private ApplicationDbContext context;
        private  IMapper mapper;
        private  UserManager<Employee> userManager;
        private  IEmployeeRepository employeeRepo;
        private  IMethodRepository methodRepo;
        private ICategoryRepository categoryRepo;

        public UnitOfWorkRepository(ApplicationDbContext context,
                                    IMapper mapper,
                                    UserManager<Employee> userManager,
                                    IEmployeeRepository employeeRepo,
                                    IMethodRepository methodRepo,
                                    ICategoryRepository categoryRepo)

        {
          
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
            this.employeeRepo = employeeRepo;
            this.methodRepo = methodRepo;
            this.categoryRepo = categoryRepo;
        }
        public IEmployeeRepository Employee => employeeRepo = employeeRepo ?? new EmployeeRepository(context, methodRepo, categoryRepo, mapper, userManager);
        
        public IMethodRepository Method
        {
            get
            {
                return methodRepo = methodRepo ?? new MethodRepository(context, categoryRepo, userManager, mapper);   
            }
        }
        

        public ICategoryRepository Category
        {
            get
            {
                return categoryRepo = categoryRepo ?? new CategoryRepository(context);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
