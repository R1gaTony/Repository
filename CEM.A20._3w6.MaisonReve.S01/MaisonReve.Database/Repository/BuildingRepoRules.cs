using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using MaisonReve.Database.Exceptions;
using MaisonReve.Database.Models;

namespace MaisonReve.Database.Repository
{
    public partial class BuildingRepo
    {
        
             public void Validate(Object entity){
                    var validationContext = new ValidationContext(entity);
                    Validator.ValidateObject(
                        entity,
                        validationContext,
                        validateAllProperties: true);//devrait être validé par ModelState.IsValid...

            }


            public void ValidateMultipleBuildings(RentingLot rentingLot){

                    var building = this.GetBuildingById(rentingLot.BuildingId);

                    if(building.RentingLots.Any(x=>x.RentingLotType == RentingLotType.FamilyHome || x.RentingLotType == RentingLotType.Townhouse))
                    throw new NotMultipleBuildingException("Vous devez changer le précédent lot locatif en appartement, condo ou unité commerciale.");


            }



            public void ValidateOnlyOneHouse(RentingLot rentingLot){

                    var building = this.GetBuildingById(rentingLot.BuildingId);
                   
                    //est-ce une maison?
                    if(rentingLot.RentingLotType == RentingLotType.FamilyHome || rentingLot.RentingLotType == RentingLotType.Townhouse){

                    //Est-ce que j'ai un autre LOT? 
                    var alreadyHaveElements = building.RentingLots.Any(x=>x.Id != rentingLot.Id);
         
                           
                    if(alreadyHaveElements)
                        throw new BuildingRepoException("Vous ne pouvez avoir deux maisons sur le même immeuble");

                    }



               

               


            }


  




            public void  ValidateLotNumber(RentingLot rentingLot){
                    if(rentingLot.RentingLotType == RentingLotType.FamilyHome || rentingLot.RentingLotType == RentingLotType.Townhouse){
                        rentingLot.LotNumber = null;
                    }
            }

            public void ValidateLeaseTerm(RentingLot rentingLot){

                    if(rentingLot.RentingLotType == RentingLotType.Commercial){

                            if(rentingLot.Terms == RentTerm.Monthly || rentingLot.Terms == RentTerm.Yearly) return;//ok
                            throw new PropertyException(nameof(rentingLot.Terms), "Un immeuble commercial doit avoir un terme annuel ou mensuel.");

                    }


            }

            public void ValidateLeaseLength(RentingLot rentingLot){


                    if(rentingLot.LeaseLength <= 0) throw new PropertyException(nameof(rentingLot.LeaseLength), "Un immeuble doit avoir un bail d'au moins 1 unité.");


                    if(rentingLot.RentingLotType == RentingLotType.Commercial){

                            if(rentingLot.Terms == RentTerm.Monthly && rentingLot.LeaseLength >= 18) return;//ok
                            if(rentingLot.Terms == RentTerm.Yearly && rentingLot.LeaseLength >= 3) return;//ok
                            throw new PropertyException(nameof(rentingLot.LeaseLength), "Un immeuble commercial doit avoir un bail d'au moins 3 ans ou 18 mois.");

                    }


            }


             public void ValidatePrice(RentingLot rentingLot){


                    if(rentingLot.Price <= 100) throw new PropertyException(nameof(rentingLot.Price), "Le prix est au minimum 100$");

            }


            public void ValidateBuildingPublishStatus(Building building){
            if(!building.RentingLots.Any()) building.Published = false;

            }


            public void ValidateBuildingAddress(Building building){
                if(string.IsNullOrWhiteSpace(building.Address)) throw new PropertyException(nameof(building.Address), "Vous devez renseigner l'adresse de l'immeuble");
            }

            public void ValidateBuildingOwner(Building building){
                if(string.IsNullOrWhiteSpace(building.OwnerFirstName)||string.IsNullOrWhiteSpace(building.OwnerLastName)||string.IsNullOrWhiteSpace(building.PhoneNumber)) throw new BuildingRepoException("Vous devez renseigner les informations du propriétaire principal de l'immeuble");
            }

            public void ValidateNoLinks(Building building){

                if(building.RentingLots.Any()) throw new BuildingRepoException("Liens toujours présents. Merci de les supprimer avant de supprimer l'immeuble.");

            }

            public void ValidateTermChange(RentingLot oldRentingLot, RentingLot newRentingLot){

                if(oldRentingLot.Terms != newRentingLot.Terms && oldRentingLot.LeaseLength == newRentingLot.LeaseLength) //il y a eu un changement!
                        newRentingLot.LeaseLength = rentTermConverter.ConvertLeaseLength(newRentingLot.LeaseLength,oldRentingLot.Terms,newRentingLot.Terms);   

            }



    }
}