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
    public class PlayersController : Controller
    {
        private IPlayerRepository _repo;

        public PlayersController(IPlayerRepository @Object)
        {
            this._repo = @Object;
        }

        // GET: Players
        public IActionResult Index()
        {
            var leBataillonDbContext = _repo.GetAll();
            return View(leBataillonDbContext);
        }

        // GET: Players/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = _repo.GetById((int)id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            ViewData["TeamId"] = new SelectList(_repo.GetAll());
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,NickName,Email,PhoneNumber,FirstName,LastName,Level,TeamId")] Player player)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(player);
                return RedirectToAction(nameof(Index));
            }
            ViewData["TeamId"] = new SelectList(_repo.GetAll().Where(p => p.TeamId == player.TeamId));
            return View(player);
        }

        // GET: Players/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = _repo.GetById((int)id);
            if (player == null)
            {
                return NotFound();
            }
            ViewData["TeamId"] = new SelectList(_repo.GetAll().Where(p => p.TeamId == player.TeamId));
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,NickName,Email,PhoneNumber,FirstName,LastName,Level,TeamId")] Player player)
        {
            if (id != player.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Edit(player);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.Id))
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
            ViewData["TeamId"] = new SelectList(_repo.GetAll().Where(p => p.TeamId == player.TeamId));
            return View(player);
        }

        // GET: Players/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = _repo.GetById((int)id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(int id)
        {
            return _repo.GetById((int)id) != null ? true : false;
        }
    }
}
