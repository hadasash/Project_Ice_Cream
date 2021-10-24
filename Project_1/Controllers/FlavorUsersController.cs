using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_1.Models;

namespace Project_1.Controllers
{
    public class FlavorUsersController : Controller
    {
        private readonly FlavorUserContext _context;

        public FlavorUsersController(FlavorUserContext context)
        {
            _context = context;
        }

        // GET: FlavorUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.FlavorUser.ToListAsync());
        }

        // GET: FlavorUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flavorUser = await _context.FlavorUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flavorUser == null)
            {
                return NotFound();
            }

            return View(flavorUser);
        }

        // GET: FlavorUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlavorUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ImagePath,Description")] FlavorUser flavorUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flavorUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flavorUser);
        }

        // GET: FlavorUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flavorUser = await _context.FlavorUser.FindAsync(id);
            if (flavorUser == null)
            {
                return NotFound();
            }
            return View(flavorUser);
        }

        // POST: FlavorUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ImagePath,Description")] FlavorUser flavorUser)
        {
            if (id != flavorUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flavorUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlavorUserExists(flavorUser.Id))
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
            return View(flavorUser);
        }

        // GET: FlavorUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flavorUser = await _context.FlavorUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flavorUser == null)
            {
                return NotFound();
            }

            return View(flavorUser);
        }

        // POST: FlavorUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flavorUser = await _context.FlavorUser.FindAsync(id);
            _context.FlavorUser.Remove(flavorUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlavorUserExists(int id)
        {
            return _context.FlavorUser.Any(e => e.Id == id);
        }
    }
}
