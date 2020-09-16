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
    public class SubjectsController : Controller
    {
        private readonly PharmacyContext _context;

        public SubjectsController(PharmacyContext context)
        {
            _context = context;
        }

        // GET: Subjects
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subjects.ToListAsync());
        }

      

        // GET: Subjects/Create
        public IActionResult AddOrEdit(int id =0 )
        {
            if (id == 0)
                return View(new Subject());
            else
            {
                return View(_context.Subjects.Find(id));
            }
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubjectId,SubjectNumber,Gender,DateOfBirth,SiteNumber")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                if (subject.SubjectId == 0)
                    _context.Add(subject);
                else
                    _context.Update(subject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }

       

        // GET: Subjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var site = await _context.Sites.FindAsync(id);
            _context.Sites.Remove(site);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
