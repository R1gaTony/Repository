using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeBataillon.Database.Context;
using LeBataillon.Database.Models;
using LeBataillon.Database.Repository;

namespace LeBataillon.Web.Controllers
{
    public class GamesController : Controller
    {
        private readonly LeBataillonDbContext _context;
        private GameRepository _repo;

        public GamesController(LeBataillonDbContext context)
        {
            _context = context;
        }

        public GamesController(GameRepository @Object)
        {
            this._repo = @Object;
        }

        // GET: Games
        public IActionResult Index()
        {
            var leBataillonDbContext = _repo.GetAll();
            return View(leBataillonDbContext);
        }

        // GET: Games/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = _repo.GetById((int)id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            ViewData["TeamAttackerId"] = new SelectList(_repo.GetAll(), "Id", "TeamName");
            ViewData["TeamDefendantId"] = new SelectList(_repo.GetAll(), "Id", "TeamName");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,GameDateTime,TeamDefendantId,TeamAttackerId")] Game game)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(game);
                return RedirectToAction(nameof(Index));
            }
            ViewData["TeamAttackerId"] = new SelectList(_repo.GetAll(), "Id", "TeamName", game.TeamAttackerId);
            ViewData["TeamDefendantId"] = new SelectList(_repo.GetAll(), "Id", "TeamName", game.TeamDefendantId);
            return View(game);
        }

        // GET: Games/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var game = _repo.GetById((int)id);
            if (game == null)
            {
                return NotFound();
            }
            ViewData["TeamAttackerId"] = new SelectList(_repo.GetAll(), "Id", "TeamName", game.TeamAttackerId);
            ViewData["TeamDefendantId"] = new SelectList(_repo.GetAll(), "Id", "TeamName", game.TeamDefendantId);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,GameDateTime,TeamDefendantId,TeamAttackerId")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Edit(game);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
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
            ViewData["TeamAttackerId"] = new SelectList(_repo.GetAll(), "Id", "TeamName", game.TeamAttackerId);
            ViewData["TeamDefendantId"] = new SelectList(_repo.GetAll(), "Id", "TeamName", game.TeamDefendantId);
            return View(game);
        }

        // GET: Games/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = _repo.GetById((int)id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _repo.GetById((int)id) != null? true : false;         
        }
    }
}
