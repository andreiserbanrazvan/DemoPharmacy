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
    public class SitesController : Controller
    {
        private readonly PharmacyContext _context;

        public SitesController(PharmacyContext context)
        {
            _context = context;
        }

        // GET: Sites
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sites.ToListAsync());
        }

        // GET: Sites/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Site());
            else
            {
                return View(_context.Sites.Find(id));
            }
        }

        // POST: Sites/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("SiteId,SiteNumber,Address,SiteDoctor")] Site site)
        {
            if (ModelState.IsValid)
            {
                if (site.SiteId == 0)
                    _context.Add(site);
                else
                    _context.Update(site);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(site);
        }

        // GET: Sites/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            var site = await _context.Sites.FindAsync(id);
            _context.Sites.Remove(site);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
