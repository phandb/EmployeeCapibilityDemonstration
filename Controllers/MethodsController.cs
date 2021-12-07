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

namespace EmployeeCapibilityDemonstration.Controllers
{
    public class MethodsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public MethodsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Methods
        public async Task<IActionResult> Index()
        {
            var methods = mapper.Map<List<MethodViewModel>>(await _context.Methods.ToListAsync());
            return View(methods);
        }

        // GET: Methods/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @method = await _context.Methods
                .FirstOrDefaultAsync(m => m.MethodId == id);
            if (@method == null)
            {
                return NotFound();
            }

            return View(@method);
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
                _context.Add(method);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(methodVM);
        }

        // GET: Methods/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @method = await _context.Methods.FindAsync(id);
            if (@method == null)
            {
                return NotFound();
            }
            return View(@method);
        }

        // POST: Methods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MethodId,Name,DateTaken,ExpiredOn")] Method @method)
        {
            if (id != @method.MethodId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@method);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MethodExists(@method.MethodId))
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
            return View(@method);
        }

        // GET: Methods/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @method = await _context.Methods
                .FirstOrDefaultAsync(m => m.MethodId == id);
            if (@method == null)
            {
                return NotFound();
            }

            return View(@method);
        }

        // POST: Methods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var @method = await _context.Methods.FindAsync(id);
            _context.Methods.Remove(@method);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MethodExists(string id)
        {
            return _context.Methods.Any(e => e.MethodId == id);
        }
    }
}
