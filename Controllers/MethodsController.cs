using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Models;
using AutoMapper;
using EmployeeCapibilityDemonstration.ViewModels.Method;
using EmployeeCapibilityDemonstration.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeCapibilityDemonstration.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class MethodsController : Controller
    {
        /* Since using Generic Repository interface, no need to inject the DbContext in 
        * Controller.  It is now handled by Generic Repository.
        * An appropriate repository will be injected here in controller, for instance
        * IMethodRepository is injected here
        */
        
        private readonly IMethodRepository methodRepo;
        private readonly IMapper mapper;

        public MethodsController(IMethodRepository methodRepo, IMapper mapper)
        {
           
            this.methodRepo = methodRepo;
            this.mapper = mapper;
        }


        /****************************************************************/
        // GET: Methods
        public async Task<IActionResult> Index()
        {
            var methods = mapper.Map<List<MethodViewModel>>(await methodRepo.GetAllAsync());
            return View(methods);
        }

        // Don't need Details here since model is so simple
        // GET: Methods/Details/5
        public async Task<IActionResult> Details(string? id)
        {
           
            var method = await methodRepo.GetByIdAsync(id);
               
            if (method == null)
            {
                return NotFound();
            }
            var methodVM = mapper.Map<MethodViewModel>(method);
            return View(methodVM);

        }

        // GET: Methods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Methods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MethodViewModel methodVM)
        {
            if (ModelState.IsValid)
            {
                var method = mapper.Map<Method>(methodVM);
                await methodRepo.AddAsync(method);
                
                return RedirectToAction(nameof(Index));
            }
            return View(methodVM);
        }

        // GET: Methods/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
           

            var method = await methodRepo.GetByIdAsync(id);
            if (method == null)
            {
                return NotFound();
            }
            var methodVM = mapper.Map<MethodViewModel>(method);
            return View(methodVM);
        }

        // POST: Methods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,  MethodViewModel methodVM)
        {
            if (id != methodVM.MethodId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Convert view model type to database type
                    var method = mapper.Map<Method>(methodVM);
                    await methodRepo.UpdateAsync(method);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await methodRepo.Exists(methodVM.MethodId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(methodVM);
        }
        /*  Will by pass the Get Deelte method and go straight to the confirmation delete
            To do that we use javascript in the index file
         */
        // GET: Methods/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var method = await methodRepo.GetByIdAsync(id);
                
            if (method == null)
            {
                return NotFound();
            }

            return View(method);
        }

        // POST: Methods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await methodRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> MethodExists(string id)
        {
            return await methodRepo.Exists(id);
        }
    }
}
