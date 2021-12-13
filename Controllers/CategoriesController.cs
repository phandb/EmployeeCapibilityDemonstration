using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Models;
using AutoMapper;
using EmployeeCapibilityDemonstration.ViewModels.Category;
using EmployeeCapibilityDemonstration.Interfaces;

namespace EmployeeCapibilityDemonstration.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository categoryRepo;
        private readonly IMapper mapper;

        /* Since using Generic Repository interface, no need to inject the DbContext in 
         * Controller.  It is now handled by Generic Repository.
         * An appropriate repository will be injected here in controller, for instance
         * CategoryRepository is injected here
         */
        public CategoriesController(ICategoryRepository categoryRepo, IMapper mapper)
        {
            this.categoryRepo = categoryRepo;
            this.mapper = mapper;
        }


        /****************************************************************/
        // GET: Categories
        public async Task<IActionResult> Index()
        {
            var categories = mapper.Map<List<CategoryViewModel>>(await categoryRepo.GetAllAsync());
            return View(categories);
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            
            var category = await categoryRepo.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            var categoryVM = mapper.Map<CategoryViewModel>(category);

            return View(categoryVM);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryViewModel categoryVM)
        {
            if (ModelState.IsValid)
            {
                var category = mapper.Map<Category>(categoryVM);  // Convert view model to model
                await categoryRepo.AddAsync(category);
                
                return RedirectToAction(nameof(Index));
            }
            return View(categoryVM);  // Reload VM if model state not valid
        }

        // GET: Categories/Edit/5  --  Show model
        public async Task<IActionResult> Edit(string id)
        {
           
            // Find the model object
            var category = await categoryRepo.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            // Convert model object to view model
            var categoryVM = mapper.Map<CategoryViewModel>(category);
            return View(categoryVM);
        }

        // POST: Categories/Edit/5  --  This method processes the edit form
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, CategoryViewModel categoryVM)
        {
            if (id != categoryVM.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Convert view model to the model
                    var category = mapper.Map<Category>(categoryVM);
                    await categoryRepo.UpdateAsync(category);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await categoryRepo.Exists(categoryVM.CategoryId))
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
            return View(categoryVM);  //Reload the view model
        }

        /*  Will by pass the Get Deelte method and go straight to the confirmation delete
            To do that we use javascript in the index file
         */

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(string id)
        {

            var category = await categoryRepo.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            
            await categoryRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> CategoryExists(string id)
        {
            return await categoryRepo.Exists(id);
        }
    }
}
