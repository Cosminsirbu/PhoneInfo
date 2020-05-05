using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneInfo.ApplicationLogic.DataModel;
using PhoneInfo.DataAccess;

namespace PhoneInfo.Controllers
{
    public class TipUsController : Controller
    {
        private readonly PhoneInfoDBContext _context;

        public TipUsController(PhoneInfoDBContext context)
        {
            _context = context;
        }

        // GET: TipUs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipUs.ToListAsync());
        }

        // GET: TipUs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipUs = await _context.TipUs
                .FirstOrDefaultAsync(m => m.TipusId == id);
            if (tipUs == null)
            {
                return NotFound();
            }

            return View(tipUs);
        }

        // GET: TipUs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipUs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Content,Date,TipusId")] TipUs tipUs)
        {
            if (ModelState.IsValid)
            {
                tipUs.TipusId = Guid.NewGuid();
                _context.Add(tipUs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipUs);
        }

        // GET: TipUs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipUs = await _context.TipUs.FindAsync(id);
            if (tipUs == null)
            {
                return NotFound();
            }
            return View(tipUs);
        }

        // POST: TipUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Email,Content,Date,TipusId")] TipUs tipUs)
        {
            if (id != tipUs.TipusId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipUs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipUsExists(tipUs.TipusId))
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
            return View(tipUs);
        }

        // GET: TipUs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipUs = await _context.TipUs
                .FirstOrDefaultAsync(m => m.TipusId == id);
            if (tipUs == null)
            {
                return NotFound();
            }

            return View(tipUs);
        }

        // POST: TipUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tipUs = await _context.TipUs.FindAsync(id);
            _context.TipUs.Remove(tipUs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipUsExists(Guid id)
        {
            return _context.TipUs.Any(e => e.TipusId == id);
        }
    }
}
