using System.Linq;
using MaisonReve.Database.Context;
using MaisonReve.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace MaisonReve.Test
{
    public abstract class InMemoryContextBaseTests
    {
         
         
         
         protected DbContextOptions<MaisonReveDbContext> contextOptions = new DbContextOptionsBuilder<MaisonReveDbContext>().UseInMemoryDatabase("TestDatabase").Options;

        public InMemoryContextBaseTests()
        {
            
        }

        protected MaisonReveDbContext PrepareContext(){

        return new MaisonReveDbContext(contextOptions);
            
        }



            protected void ClearContext(MaisonReveDbContext context){


                context.Database.EnsureDeleted(); //on supprime les tables
                context.Database.EnsureCreated(); //on rajoute les tables (sans le seed!)
           
                
            }




            protected void ClearContextAndData(MaisonReveDbContext context){


                context.Database.EnsureDeleted(); //on supprime les tables
                context.Database.EnsureCreated(); //on rajoute les tables (sans le seed!)
                context.RentingLots.RemoveRange(context.RentingLots.ToList());
                context.Buildings.RemoveRange(context.Buildings.ToList());
                context.SaveChanges();
                
            }

        protected void SeedWithOneBuildingOneRentingLot(RentingLotType type){

                using(var context = PrepareContext()){


                   ClearContextAndData(context);

                    var building = new Building(1, "MonTextBuilding", "MonAddresse", "4501234567","Pink", "Floyd", "Un super building où il fait bon vivre!");
                    var rentingLot = new RentingLot(){ Id=1, BuildingId = 1, LeaseLength = 12, LotNumber=null, Price=1300, NumberOfRooms=8, RentingLotType = type, Terms = RentTerm.Monthly };
                    context.Buildings.Add(building);
                    context.RentingLots.Add(rentingLot);
                    
                    context.SaveChanges();

                    
                }


        }


        protected void SeedWithOneBuilding(){

                using(var context = PrepareContext()){


                   ClearContextAndData(context);

                    var building = new Building(1, "MonTextBuilding", "MonAddresse", "4501234567","Pink", "Floyd", "Un super building où il fait bon vivre!");
                    context.Buildings.Add(building);
                    
                    context.SaveChanges();

                    
                }


        }







    }
}