using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaisonReve.Database.Exceptions;
using MaisonReve.Database.Models;
using MaisonReve.Database.Repository;

namespace MaisonReve.Web.Controllers
{
    public class BuildingsController : Controller
    {
        private readonly IBuildingRepo _repo;

        public BuildingsController(IBuildingRepo repo)
        {
            _repo = repo;
        }

        // GET: Buildings
        public IActionResult Index()
        {
            return View(_repo.GetAllBuildings());
        }

        // GET: Buildings/Details/5
        public IActionResult Details(int? id)
        {
            try{

                var building = this._repo.GetBuildingById(id??0);
                return View(building);
                    

            }catch(NotFoundException){
               
                return NotFound();
            }

        }

        // GET: Buildings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Buildings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Address,PhoneNumber,OwnerFirstName,OwnerLastName,Description,Published")] Building building)
        {
            if (ModelState.IsValid)
            {
                try{

                         _repo.Add(building);
                         return RedirectToAction(nameof(Index));
                
                }catch(BuildingRepoException e){

                        this.ModelState.AddModelError(e.Property, e.Message);

                }
               

               
            }
            return View(building);
        }

        // GET: Buildings/Edit/5
        public IActionResult Edit(int? id)
        {

            try{

                var building = this._repo.GetBuildingById(id);
                return View(building);
                    

            }catch(NotFoundException){
               
                return NotFound();
            }


        }

        // POST: Buildings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Address,PhoneNumber,OwnerFirstName,OwnerLastName,Description,Published")] Building building)
        {
   
            if (ModelState.IsValid)
            {
                try{

                         _repo.Edit(building);
                         return RedirectToAction(nameof(Index));
                
                }
                catch(NotFoundException){
                //log me!
                return NotFound();
                
                }
                catch(BuildingRepoException e){

                        this.ModelState.AddModelError(e.Property, e.Message);

                }
                                 
            }
            return View(building);
        }


        public IActionResult Publish(int? id)
        {

            try{

                _repo.Publish(id);
                return RedirectToAction(nameof(Index));
                
                }catch(NotFoundException){
                //log me!
                return NotFound();
                
                }
                catch(BuildingRepoException e){

                        this.ModelState.AddModelError(e.Property, e.Message);

                }
               

            return RedirectToAction(nameof(Index));
        }


       public IActionResult Unpublish(int? id)
        {
             try{

                         _repo.Unpublish(id);
                         return RedirectToAction(nameof(Index));
                
                }catch(NotFoundException){
                //log me!
                return NotFound();
                
                }
                catch(BuildingRepoException){

                    //do nothing. 
                   
                }
               

            return RedirectToAction(nameof(Index));
        }



        // GET: Buildings/Delete/5
        public IActionResult Delete(int? id)
        {
             try{

                var building = this._repo.GetBuildingById(id);
                return View(building);
                    

            }catch(NotFoundException){
              
                return NotFound();
            }


            
        }

        // POST: Buildings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int id)
        {
                try{

                         _repo.RemoveBuilding(id);
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
