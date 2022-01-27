using AutoMapper;
using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.ViewModels.Employee;
using Microsoft.AspNetCore.Identity;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class EmployeeMethodRepository : GenericRepository<EmployeeMethod>, IEmployeeMethodRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;

        public EmployeeMethodRepository(ApplicationDbContext context,
                                        IMapper mapper,
                                        IHttpContextAccessor httpContextAccessor,
                                        UserManager<Employee> userManager) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
        }

        public async Task AddMethodToEmployee(EmployeeAddMethodViewModel model)
        {
            // get current user loggin
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            var employeeMethod = new EmployeeMethod()
            {
                Id = user.Id,
                MethodId = model.MethodId,
                TakenDate = model.DateTaken,
                ExpiredDate = model.DateExpired

            };
           

            await AddAsync(employeeMethod);
        }
    }
}
