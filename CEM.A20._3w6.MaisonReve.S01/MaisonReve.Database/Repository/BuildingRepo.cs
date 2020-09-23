using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MaisonReve.Database.Context;
using MaisonReve.Database.Exceptions;
using MaisonReve.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace MaisonReve.Database.Repository
{
    public interface IBuildingRepo
    {
        Building Add(Building building);
        RentingLot Add(RentingLot rentingLot);
        void BuildingExistsCheck(int? id);
        Building Edit(Building building);
        RentingLot Edit(RentingLot rentingLot);
        List<Building> GetAllBuildings();
        List<RentingLot> GetAllRentingLots();
        Building GetBuildingById(int? id);
        RentingLot GetRentingLotById(int? id);
        void Publish(int? buildingId);
        bool RemoveBuilding(int id);
        bool RemoveRentingLot(int id);
        void RentingLotExistsCheck(int? id);
        void Unpublish(int? buildingId);
        void Validate(object entity);
        void ValidateBuildingAddress(Building building);
        void ValidateBuildingOwner(Building building);
        void ValidateBuildingPublishStatus(Building building);
        void ValidateLeaseLength(RentingLot rentingLot);
        void ValidateLeaseTerm(RentingLot rentingLot);
        void ValidateLotNumber(RentingLot rentingLot);
        void ValidateMultipleBuildings(RentingLot rentingLot);
        void ValidateNoLinks(Building building);
        void ValidateOnlyOneHouse(RentingLot rentingLot);
        void ValidatePrice(RentingLot rentingLot);
        void ValidateTermChange(RentingLot oldRentingLot, RentingLot newRentingLot);
    }

    public partial class BuildingRepo : IBuildingRepo
    {

        MaisonReveDbContext context;
        IRentTermConverter rentTermConverter;

        public BuildingRepo(MaisonReveDbContext context, IRentTermConverter converter)
        {
            this.context = context;
            this.rentTermConverter = converter;
        }

        public Building Add(Building building)
        {
            Validate(building);
            ValidateBuildingAddress(building);
            ValidateBuildingOwner(building);
            ValidateBuildingPublishStatus(building);

            this.context.Buildings.Add(building);
            this.context.SaveChanges();

            return building;
        }



        public RentingLot Add(RentingLot rentingLot)
        {


            Validate(rentingLot);
            ValidateMultipleBuildings(rentingLot);
            ValidateOnlyOneHouse(rentingLot);
            ValidateLotNumber(rentingLot);
            ValidateLeaseTerm(rentingLot);
            ValidateLeaseLength(rentingLot);
            ValidatePrice(rentingLot);


            this.context.RentingLots.Add(rentingLot);
            this.context.SaveChanges();
            return rentingLot;

        }


        public bool RemoveBuilding(int id)
        {

            var el = this.GetBuildingById(id);
            this.ValidateNoLinks(el);


            this.context.Buildings.Remove(el);
            this.context.SaveChanges();

            return true;

        }

        public bool RemoveRentingLot(int id)
        {

            var el = this.GetRentingLotById(id);
            var b = el.Building;

            this.context.RentingLots.Remove(el);

            ValidateBuildingPublishStatus(b);

            this.context.SaveChanges();

            return true;

        }


        public void Publish(int? buildingId)
        {
            var building = this.GetBuildingById(buildingId);
            building.Published = true;
            this.Edit(building);
        }

        public void Unpublish(int? buildingId)
        {
            var building = this.GetBuildingById(buildingId);
            building.Published = false;
            this.Edit(building);
        }

        public Building Edit(Building building)
        {

            Validate(building);
            ValidateBuildingAddress(building);
            ValidateBuildingOwner(building);
            ValidateBuildingPublishStatus(building);



            var el = this.GetBuildingById(building.Id);
            el.EditFrom(building);


            try
            {

                this.context.SaveChanges();

            }
            catch (DbUpdateConcurrencyException)
            {
                this.BuildingExistsCheck(building.Id);
                throw;
            }


            return el;
        }

        public RentingLot Edit(RentingLot rentingLot)
        {

            Validate(rentingLot);

            ValidateOnlyOneHouse(rentingLot);
            ValidateLotNumber(rentingLot);
            ValidateLeaseTerm(rentingLot);
            ValidatePrice(rentingLot);

            var el = this.GetRentingLotById(rentingLot.Id);

            ValidateTermChange(el, rentingLot);
            ValidateLeaseLength(rentingLot);

            el.EditFrom(rentingLot);





            try
            {
                this.context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                this.RentingLotExistsCheck(rentingLot.Id);
                throw;
            }

            return el;
        }


        public List<Building> GetAllBuildings()
        {
            return this.context.Buildings.ToList();
        }

        public List<RentingLot> GetAllRentingLots()
        {
            return this.context.RentingLots.ToList();
        }


        public Building GetBuildingById(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(Building)} : {id} not found");
            var el = this.context.Buildings.FirstOrDefault(x => x.Id == id);
            if (el == null) throw new NotFoundException($"{nameof(Building)} : {id} not found");
            return el;
        }

        public void RentingLotExistsCheck(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(RentingLot)} : {id} not found");
            var el = this.context.RentingLots.Any(x => x.Id == id);
            if (el) throw new NotFoundException($"{nameof(RentingLot)} : {id} not found");


        }



        public void BuildingExistsCheck(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(Building)} : {id} not found");
            var el = this.context.Buildings.Any(x => x.Id == id);
            if (el) throw new NotFoundException($"{nameof(Building)} : {id} not found");


        }

        public RentingLot GetRentingLotById(int? id)
        {
            if (id == null) throw new NotFoundException($"{nameof(RentingLot)} : {id} not found");
            var el = this.context.RentingLots.FirstOrDefault(x => x.Id == id);
            if (el == null) throw new NotFoundException($"{nameof(RentingLot)} : {id} not found");
            return el;
        }


    }
}
