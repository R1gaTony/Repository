using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaisonReve.Database.Context;
using MaisonReve.Database.Models;
using MaisonReve.Database.Exceptions;
using MaisonReve.Database.Repository;

namespace MaisonReve.Web.Controllers
{
    public class RentingLotsController : Controller
    {
         private readonly IBuildingRepo _repo;

        public RentingLotsController(IBuildingRepo repo)
        {
            _repo = repo;
        }
        // GET: RentingLots
        public IActionResult Index()
        {
            return View(_repo.GetAllRentingLots());
        }

        // GET: RentingLots/Details/5
        public IActionResult Details(int? id)
        {
            try{

                var rentingLot = this._repo.GetRentingLotById(id??0);
                return View(rentingLot);
                    

            }catch(NotFoundException){
               
                return NotFound();
            }

          
        }

        // GET: RentingLots/Create
        public IActionResult Create()
        {
            ViewData["BuildingId"] = new SelectList(_repo.GetAllBuildings(), "Id", "Name");
            return View();
        }

        // POST: RentingLots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,LotNumber,Price,Terms,LeaseLength,NumberOfRooms,RentingLotType,BuildingId")] RentingLot rentingLot)
        {
            if (ModelState.IsValid)
            {
                 try{

                         var r = _repo.Add(rentingLot);
                         return RedirectToAction(nameof(Details),new {Id = r.Id});
                
                }catch(BuildingRepoException e){

                        this.ModelState.AddModelError(e.Property, e.Message);

                }
            }
            ViewData["BuildingId"] = new SelectList(_repo.GetAllBuildings(), "Id", "Name", rentingLot.BuildingId);
            return View(rentingLot);
        }

        // GET: RentingLots/Edit/5
        public IActionResult Edit(int? id)
        {
          
            try{

                var rentingLot = this._repo.GetRentingLotById(id); 
                ViewData["BuildingId"] = new SelectList(_repo.GetAllBuildings(), "Id", "Name", rentingLot.BuildingId);
                return View(rentingLot);
                    

            }catch(NotFoundException){
               
                return NotFound();
            }
           
        }

        // POST: RentingLots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,LotNumber,Price,Terms,LeaseLength,NumberOfRooms,RentingLotType,BuildingId")] RentingLot rentingLot)
        {
            if (ModelState.IsValid)
            {
                try{

                      var r = _repo.Edit(rentingLot);
                          return RedirectToAction(nameof(Details),new {Id = r.Id});
                
                
                }
                catch(NotFoundException){
                //log me!
                return NotFound();
                
                }
                catch(BuildingRepoException e){

                        this.ModelState.AddModelError(e.Property, e.Message);

                }
                                 
            }
            ViewData["BuildingId"] = new SelectList(_repo.GetAllBuildings(), "Id", "Name", rentingLot.BuildingId);
            return View(rentingLot);
        }

        // GET: RentingLots/Delete/5
        public IActionResult Delete(int? id)
        {
                      try{

                var rentingLot = this._repo.GetRentingLotById(id);
                return View(rentingLot);
                    

            }catch(NotFoundException){
              
                return NotFound();
            }
        }

        // POST: RentingLots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
                try{

                         _repo.RemoveRentingLot(id);
                         return RedirectToAction(nameof(Index));
                
                }
                catch(NotFoundException){
                //log me!
                return NotFound();
                
                }
                catch(BuildingRepoException e){

                        this.ModelState.AddModelError(e.Property, e.Message);

                }
            return RedirectToAction(nameof(Index));
        }

    }
}
