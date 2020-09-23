using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaisonReve.Database.Context;
using MaisonReve.Database.Models;

namespace MaisonReve.Web.Controllers
{
    public class RentingLotsController : Controller
    {
        private readonly MaisonReveDbContext _context;

        public RentingLotsController(MaisonReveDbContext context)
        {
            _context = context;
        }

        // GET: RentingLots
        public async Task<IActionResult> Index()
        {
            var maisonReveDbContext = _context.RentingLots.Include(r => r.Building);
            return View(await maisonReveDbContext.ToListAsync());
        }

        // GET: RentingLots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentingLot = await _context.RentingLots
                .Include(r => r.Building)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rentingLot == null)
            {
                return NotFound();
            }

            return View(rentingLot);
        }

        // GET: RentingLots/Create
        public IActionResult Create()
        {
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "Id", "Name");
            return View();
        }

        // POST: RentingLots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LotNumber,Price,Terms,LeaseLength,NumberOfRooms,RentingLotType,BuildingId")] RentingLot rentingLot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentingLot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "Id", "Name", rentingLot.BuildingId);
            return View(rentingLot);
        }

        // GET: RentingLots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentingLot = await _context.RentingLots.FindAsync(id);
            if (rentingLot == null)
            {
                return NotFound();
            }
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "Id", "Name", rentingLot.BuildingId);
            return View(rentingLot);
        }

        // POST: RentingLots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LotNumber,Price,Terms,LeaseLength,NumberOfRooms,RentingLotType,BuildingId")] RentingLot rentingLot)
        {
            if (id != rentingLot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentingLot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentingLotExists(rentingLot.Id))
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
            ViewData["BuildingId"] = new SelectList(_context.Buildings, "Id", "Name", rentingLot.BuildingId);
            return View(rentingLot);
        }

        // GET: RentingLots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentingLot = await _context.RentingLots
                .Include(r => r.Building)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rentingLot == null)
            {
                return NotFound();
            }

            return View(rentingLot);
        }

        // POST: RentingLots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentingLot = await _context.RentingLots.FindAsync(id);
            _context.RentingLots.Remove(rentingLot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentingLotExists(int id)
        {
            return _context.RentingLots.Any(e => e.Id == id);
        }
    }
}
