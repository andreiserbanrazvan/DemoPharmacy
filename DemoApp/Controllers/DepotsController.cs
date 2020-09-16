using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoApp.Models;

namespace DemoApp.Controllers
{
    public class DepotsController : Controller
    {
        private readonly PharmacyContext _context;

        public DepotsController(PharmacyContext context)
        {
            _context = context;
        }

        // GET: Depots
        public async Task<IActionResult> Index()
        {
            return View(await _context.Depots.ToListAsync());
        }

        // GET: Depots/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Depot());
            else
            {
                return View(_context.Depots.Find(id));
            }
        }

        // POST: Depots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("DepotId")] Depot depot)
        {
            if (ModelState.IsValid)
            {
                if (depot.DepotId == 0)
                    _context.Add(depot);
                else
                    _context.Update(depot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(depot);
        }

     

        // GET: Depots/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            var depot = await _context.Depots.FindAsync(id);
            _context.Depots.Remove(depot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
