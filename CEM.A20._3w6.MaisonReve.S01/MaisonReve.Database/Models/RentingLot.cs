using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaisonReve.Database.Models
{
    public class RentingLot{


public RentingLot()
{
    
}



       [Key]
        public int Id{get;set;}

        [Display(Name = "Numéro du lot (optionnel)")]
        public string LotNumber{get;set;}

        [Display(Name = "Prix")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price{get;set;}

        [Display(Name = "Terme de la location")]
        public RentTerm Terms{get;set;}

        [Display(Name = "Durée du bail offert")]
        public int LeaseLength{get;set;}

        [Display(Name = "Nombre de pièces")]
        [Range(1,int.MaxValue,ErrorMessage="RoomMin1")]
        public int NumberOfRooms{get;set;}

        [Display(Name = "Type")]
        public RentingLotType RentingLotType{get;set;}

        [Display(Name = "Immeuble")]
        public int BuildingId{get;set;}

        [Display(Name = "Immeuble")]
        public virtual Building Building {get;set;}
   
        public void EditFrom(RentingLot rentingLot)
        {
            this.Id = rentingLot.Id;
            this.LotNumber = rentingLot.LotNumber; 
            this.Price = rentingLot.Price;
            this.Terms = rentingLot.Terms;
            this.LeaseLength = rentingLot.LeaseLength;
            this.NumberOfRooms = rentingLot.NumberOfRooms;
            this.RentingLotType = rentingLot.RentingLotType;
        }


}





}