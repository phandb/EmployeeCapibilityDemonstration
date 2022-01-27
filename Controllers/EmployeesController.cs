using AutoMapper;
using EmployeeCapibilityDemonstration.Constants;
using EmployeeCapibilityDemonstration.Interfaces;
using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.Repositories;
using EmployeeCapibilityDemonstration.ViewModels.Employee;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeCapibilityDemonstration.Controllers
{
    //[Authorize(Roles =  Roles.Administrator)]
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IEmployeeRepository employeeRepo;
        private readonly IMethodRepository methodRepo;
        private readonly IEmployeeMethodRepository employeeMethodRepo;
        private readonly IMapper mapper;

        public EmployeesController(UserManager<Employee> userManager,
                                   IEmployeeRepository employeeRepo,
                                   IMethodRepository methodRepo,
                                   IEmployeeMethodRepository employeeMethodRepo,
                                   IMapper mapper)
        {
            this.userManager = userManager;
            this.employeeRepo = employeeRepo;
            this.methodRepo = methodRepo;
            this.employeeMethodRepo = employeeMethodRepo;
            this.mapper = mapper;
        }



        [Authorize(Roles = Roles.Administrator)]
        // GET: EmployeesController
        public async Task<ActionResult> Index()
        {
            // Retrieve data from database
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);

            //Convert to view model
            var model = mapper.Map<List<EmployeeListViewModel>>(employees);
            return View(model);
        }


        
        // GET: EmployeesController/Details
        public async Task<ActionResult> Details()
        {

            var model = await employeeRepo.GetEmployeeDetail();
            return View(model);
        }
        /*
        // GET: EmployeesController/Details/employeeId
        public async Task<ActionResult> Details(string id)
        {

            var model = await employeeRepo.GetEmployeeMethods(id);
            return View(model);
        }
        */
        private void PopulatedMethodsDropDownList(object selectedMethod = null)
        {
            var methodsQuery = methodRepo.GetAllAsync();
            ViewBag.MethodId = new SelectList(methodsQuery.Result, "MethodId", "Name", selectedMethod);
                 
        }


        [Authorize(Roles = Roles.User)]
        // GET: Employees/Create
        public async Task<ActionResult> AddMethod()
        {
            var model = await employeeRepo.PopulateMethodsDropDownList();
             return View(model);
           // PopulatedMethodsDropDownList();
            //return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddMethod(EmployeeAddMethodViewModel AddMethodVM)
        {
            if (!ModelState.IsValid)
            { 
                
                await employeeMethodRepo.AddMethodToEmployee(AddMethodVM);
                return RedirectToAction(nameof(Details));
            }
            //PopulatedMethodsDropDownList();
            return View(AddMethodVM);
            
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
