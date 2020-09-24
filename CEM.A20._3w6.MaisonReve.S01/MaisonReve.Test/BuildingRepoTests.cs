using MaisonReve.Database.Exceptions;
using MaisonReve.Database.Models;
using MaisonReve.Database.Repository;
using Xunit;

namespace MaisonReve.Test
{
    public class BuildingRepoTests : InMemoryContextBaseTests
    {

        private BuildingRepo _repo;

        public BuildingRepoTests()
        {
            _repo = new BuildingRepo(PrepareContext(), new RentTermConverter());

        }

        [Fact]
        public void ValidateOnlyOneHouse_UneMaisonDeVilleLorqueUneDeja(){
            //Arrange
          this.SeedWithOneBuildingOneRentingLot(RentingLotType.Townhouse);
          var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=2, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Townhouse, Terms = RentTerm.Yearly};
           
           //Act & Assert
            var exception =  Assert.Throws<BuildingRepoException>(()=>this._repo.ValidateOnlyOneHouse(newRentingLot));
            Assert.Equal(exception.Message, "Vous ne pouvez avoir deux maisons sur le même immeuble");

        }

        [Fact]
        public void ValidateOnlyOneHouse_UneMaisonDeVilleLorqueAucun(){
            //Arrange
          this.SeedWithOneBuilding();
          var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=2, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Townhouse, Terms = RentTerm.Yearly};
           
           //Act & Assert
           this._repo.ValidateOnlyOneHouse(newRentingLot); //should pass...



        }


        [Fact]
        public void ValidateOnlyOneHouse_UneMaisonDeVilleLorqueAppartement(){
            //Arrange
          this.SeedWithOneBuildingOneRentingLot(RentingLotType.Appartment);
          var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=2, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Townhouse, Terms = RentTerm.Yearly};
           
           //Act & Assert
            var exception =  Assert.Throws<BuildingRepoException>(()=>this._repo.ValidateOnlyOneHouse(newRentingLot));
            Assert.Equal(exception.Message, "Vous ne pouvez avoir deux maisons sur le même immeuble");

        }

        [Fact]
        public void ValidateBuildingAddress_AdresseNull(){
            //Arrange
            var newBuilding = new Building();
            newBuilding.Address = null;
           
           //Act & Assert
            var exception =  Assert.Throws<PropertyException>(()=>this._repo.ValidateBuildingAddress(newBuilding));
            Assert.Equal(exception.Message, "Vous devez renseigner l'adresse de l'immeuble");

        }
        [Fact]
        public void ValidateBuildingAddress_AdresseBlanche(){
            //Arrange
            var newBuilding = new Building();
            newBuilding.Address = "";
           
           //Act & Assert
            var exception =  Assert.Throws<PropertyException>(()=>this._repo.ValidateBuildingAddress(newBuilding));
            Assert.Equal(exception.Message, "Vous devez renseigner l'adresse de l'immeuble");

        }
        [Fact]
        public void ValidateBuildingOwner_ChampsNull(){
            //Arrange
            var newBuilding = new Building();
            newBuilding.OwnerFirstName = null;
            newBuilding.OwnerLastName = null;
            newBuilding.PhoneNumber = null;

            //Act & Assert
            var exception =  Assert.Throws<BuildingRepoException>(()=>this._repo.ValidateBuildingOwner(newBuilding));
            Assert.Equal(exception.Message, "Vous devez renseigner les informations du propriétaire principal de l'immeuble");
        }

        [Fact]
        public void ValidateBuildingOwner_ChampsBlanc(){
            //Arrange
            var newBuilding = new Building();
            newBuilding.OwnerFirstName = "";
            newBuilding.OwnerLastName = "";
            newBuilding.PhoneNumber = "";

            //Act & Assert
            var exception =  Assert.Throws<BuildingRepoException>(()=>this._repo.ValidateBuildingOwner(newBuilding));
            Assert.Equal(exception.Message, "Vous devez renseigner les informations du propriétaire principal de l'immeuble");
        }

        [Fact]
        public void ValidateBuildingPublishStatus(){
            //Arrange
            this.SeedWithOneBuilding();
           var building = this._repo.GetBuildingById(1);
           building.Published = true;
            //Act & Assert
            this._repo.ValidateBuildingPublishStatus(building);

            Assert.Equal(building.Published, false);

        }


      [Fact]
        public void ValidateBuildingPublishStatusWithRentingLots(){
            //Arrange
            this.SeedWithOneBuildingOneRentingLot(RentingLotType.Appartment);
           var building = this._repo.GetBuildingById(1);
           building.Published = true;
            //Act & Assert
            this._repo.ValidateBuildingPublishStatus(building);

            Assert.Equal(building.Published, true);


        }


        [Fact]
        public void ValidateOnlyOneHouse(){
            //Arrange
            this.SeedWithOneBuildingOneRentingLot(RentingLotType.Townhouse);
            var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=2, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Townhouse, Terms = RentTerm.Yearly};
           
            //Act & Assert
            var exception =  Assert.Throws<BuildingRepoException>(()=>this._repo.ValidateOnlyOneHouse(newRentingLot));
            Assert.Equal(exception.Message, "Vous ne pouvez avoir deux maisons sur le même immeuble");
        }

        [Fact]
        public void ValidateLeaseTerm_Week(){
            //Arrange
            var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=2, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Commercial, Terms = RentTerm.Weekly};
           
            //Act & Assert
            var exception =  Assert.Throws<PropertyException>(()=>this._repo.ValidateLeaseTerm(newRentingLot));
            Assert.Equal(exception.Message, "Un immeuble commercial doit avoir un terme annuel ou mensuel.");
        }

        [Fact]
        public void ValidateLeaseTerm_Daily(){
            //Arrange
            var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=2, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Commercial, Terms = RentTerm.Daily};
           
            //Act & Assert
            var exception =  Assert.Throws<PropertyException>(()=>this._repo.ValidateLeaseTerm(newRentingLot));
            Assert.Equal(exception.Message, "Un immeuble commercial doit avoir un terme annuel ou mensuel.");
        }
        [Fact]
        public void ValidateLeaseLength_0(){
            //Arrange
            var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=0, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Commercial, Terms = RentTerm.Yearly};
           
            //Act & Assert
            var exception =  Assert.Throws<PropertyException>(()=>this._repo.ValidateLeaseLength(newRentingLot));
            Assert.Equal(exception.Message, "Un immeuble doit avoir un bail d'au moins 1 unité.");
        }

        [Fact]
        public void ValidateLeaseLength_Monthly(){
            //Arrange
            var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=17, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Commercial, Terms = RentTerm.Monthly};
           
            //Act & Assert
            var exception =  Assert.Throws<PropertyException>(()=>this._repo.ValidateLeaseLength(newRentingLot));
            Assert.Equal(exception.Message, "Un immeuble commercial doit avoir un bail d'au moins 3 ans ou 18 mois.");
        }

        [Fact]
        public void ValidateLeaseLength_Yearly(){
            //Arrange
            var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=2, LotNumber=null, NumberOfRooms = 5, Price = 500, RentingLotType = RentingLotType.Commercial, Terms = RentTerm.Yearly};
           
            //Act & Assert
            var exception =  Assert.Throws<PropertyException>(()=>this._repo.ValidateLeaseLength(newRentingLot));
            Assert.Equal(exception.Message, "Un immeuble commercial doit avoir un bail d'au moins 3 ans ou 18 mois.");
        }

        [Fact]
        public void ValidatePrice(){
            //Arrange
            var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=2, LotNumber=null, NumberOfRooms = 5, Price = 100, RentingLotType = RentingLotType.Commercial, Terms = RentTerm.Yearly};
            //Act & Assert
            var exception =  Assert.Throws<PropertyException>(()=>this._repo.ValidatePrice(newRentingLot));
            Assert.Equal(exception.Message, "Le prix est au minimum 100$");
        }

        [Fact]
        public void ValidateTermChange(){
            //Arrange
            var oldRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=3, LotNumber=null, NumberOfRooms = 5, Price = 100, RentingLotType = RentingLotType.Commercial, Terms = RentTerm.Yearly};

            var newRentingLot = new RentingLot(){Id=2, BuildingId=1, LeaseLength=3, LotNumber=null, NumberOfRooms = 5, Price = 100, RentingLotType = RentingLotType.Commercial, Terms = RentTerm.Monthly};
            //Act
            this._repo.ValidateTermChange(oldRentingLot, newRentingLot);
            //Assert
            Assert.Equal(oldRentingLot.LeaseLength != newRentingLot.LeaseLength, true);
        }
        [Fact]
        public void ValidateBuildingPublishStatus_Supprime(){
            //Arrange
            this.SeedWithOneBuildingOneRentingLot(RentingLotType.Appartment);
            var building = this._repo.GetBuildingById(1);
            building.RentingLots.Clear();
            building.Published = true;
            //Act & Assert
            this._repo.ValidateBuildingPublishStatus(building);

            Assert.Equal(building.Published, false);
           
        }
    }
}