using Microsoft.EntityFrameworkCore;
using MaisonReve.Database.Models;
using System.Collections.Generic;
using MaisonReve.Database.Initializer.DataFixtures;
using System;
using System.Linq;

namespace MaisonReve.Database.Context
{
    public class MaisonReveDbContext : DbContext
    {
        public MaisonReveDbContext(DbContextOptions<MaisonReveDbContext> options):base(options)
        {

        }

        public DbSet<Building> Buildings {get;set;}
        public DbSet<RentingLot> RentingLots {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
                optionsBuilder.UseLazyLoadingProxies();
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
                //seed 
                var buildings = new List<Building>();
                for (int i = 1; i < 200; i++)
                {
                var name = "Le Super " + SampleData.GenerateName(i);
                    buildings.Add(new Building(i, name, SampleData.GenerateAddress(i), SampleData.GeneratePhoneNumber(i),SampleData.GenerateName(i+1), SampleData.GenerateLastName(i+1), $"{name} est un immeuble extra, où il fait bon vivre!"));
                } 
 
                modelBuilder.Entity<Building>().HasData(buildings);

                //seed
                var rentingLots = new List<RentingLot>();
                for (int i = 1; i < 200; i++)
                {
                 
                    var rand = new Random(i);
                    var numberOfLots = rand.Next(0,10);
                    var RentingLotToAdd = new List<RentingLot>();
                    for (int j = 1; j <= numberOfLots; j++)
                    {
                        var uniqueNumber = i * 1000 + j * 100;
                        var rentingLot = new RentingLot();
                        int? lotNumber = j;
                        var price = SampleData.GenerateDecimal(uniqueNumber,100,1000);
                        var rentTerm = (RentTerm)SampleData.GenerateInteger(uniqueNumber+1,0,3);
                        var LeaseLength = SampleData.GenerateInteger(uniqueNumber+2,1,50);
                        var numberOfRooms = SampleData.GenerateInteger(uniqueNumber+3,1,10);
                        var RentingLotType  = (RentingLotType)SampleData.GenerateInteger(uniqueNumber+4,0,5);
                        //business rules
                        if(RentingLotType == RentingLotType.Townhouse || RentingLotType == RentingLotType.FamilyHome){
                            if(RentingLotToAdd.Any()) RentingLotType = RentingLotType.Appartment;
                            else {lotNumber = null;RentingLotToAdd.Clear();numberOfLots = 1;}
                        }
                        if(RentingLotType == RentingLotType.Commercial){
                            if(rentTerm != RentTerm.Monthly && rentTerm != RentTerm.Yearly)    rentTerm = RentTerm.Monthly;
                            if(rentTerm == RentTerm.Monthly)LeaseLength = Math.Max(18,LeaseLength);
                            if(rentTerm == RentTerm.Yearly) LeaseLength = Math.Max(3,LeaseLength);
                        }
                        var newRentingLot = new RentingLot(){
                            Id = rentingLots.Count + RentingLotToAdd.Count + 1,
                            BuildingId = i,
                            LeaseLength = LeaseLength,
                            LotNumber = lotNumber?.ToString(),
                            NumberOfRooms = numberOfRooms,
                            RentingLotType = RentingLotType,
                            Terms = rentTerm,
                            Price = price};
                        RentingLotToAdd.Add(newRentingLot);
                    }
                 
                    rentingLots.AddRange(RentingLotToAdd);
                }
                 
                modelBuilder.Entity<RentingLot>().HasData(rentingLots);

        }



    }
}