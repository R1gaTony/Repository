using System;
using System.Collections.Generic;
using System.Linq;
using MaisonReve.Database.Context;
using MaisonReve.Database.Exceptions;
using MaisonReve.Database.Models;

namespace MaisonReve.Database.Repository
{
    public class BuildingRepo
    {

        BuildingStaticData db = new BuildingStaticData();

        public object locker = new Object();

        public BuildingRepo() => db.EnsureCreated();

        public Building Add(Building b){
                    lock(locker){

                    b.Id = this.db.Data.Max(x=>x.Id) + 1;
                    this.db.Data.Add(b);

                    }
                return b;
        }

            public bool Remove(int id){

               var el = this.GetById(id);

               return this.db.Data.Remove(el);
              
            }

            public Building Edit(Building b){

                    var el = this.GetById(b.Id);
                    el.EditFrom(b);
                    return el;
            }

            public List<Building> GetAll(){
             return this.db.Data.ToList();


            }

         

            public Building GetById(int id){
                var el = this.db.Data.FirstOrDefault(x=>x.Id == id);
                 if(el == null) throw new NotFoundException($"{nameof(Building)} : {id} not found");
                return el;
            }




    }
}
