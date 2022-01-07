using AutoMapper;
using EmployeeCapibilityDemonstration.Constants;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.Repositories;
using EmployeeCapibilityDemonstration.ViewModels.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCapibilityDemonstration.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IEmployeeRepository employeeRepo;
        private readonly IMethodRepository methodRepo;
        private readonly IMapper mapper;

        public EmployeesController(UserManager<Employee> userManager,
                                   IEmployeeRepository employeeRepo,
                                   IMethodRepository methodRepo,
                                   IMapper mapper)
        {
            this.userManager = userManager;
            this.employeeRepo = employeeRepo;
            this.methodRepo = methodRepo;
            this.mapper = mapper;
        }




        // GET: EmployeesController
        public async Task<ActionResult> Index()
        {
            // Retrieve data from database
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);

            //Convert to view model
            var model = mapper.Map<List<EmployeeListViewModel>>(employees);
            return View(model);
        }

        // GET: EmployeesController/Details/employeeId
        public async Task<ActionResult> Details(string id)
        {

            var model = await employeeRepo.GetEmployeeMethods(id);
            return View(model);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
