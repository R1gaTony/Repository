using System.ComponentModel.DataAnnotations;

namespace MaisonReve.Database.Models {
    public class Building {


        public Building()
        {
            
        }
        public Building(int Id, string Name, string Address, string PhoneNumber, string OwnerFirstName, string OwnerLastName, string Description)
        {
            this.Id = Id;
            this.Name = Name; 
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.OwnerFirstName = OwnerFirstName;
            this.OwnerLastName = OwnerLastName;
            this.Description = Description;
        }

        public void EditFrom(Building b)
        {
            this.Id = b.Id;
            this.Name = b.Name; 
            this.Address = b.Address;
            this.PhoneNumber = b.PhoneNumber;
            this.OwnerFirstName = b.OwnerFirstName;
            this.OwnerLastName = b.OwnerLastName;
            this.Description = b.Description;
        }

            [Key]
            public int Id{get;set;}

            [Required(ErrorMessage = "Le nom est requis")] 
            public string Name{get;set;}



            [Display(Name = "Adresse")]
            [DataType(DataType.MultilineText)]
            [MaxLength(500, ErrorMessage="Maximum de 500 caractères pour l'adresse.")]
            public string Address{get;set;}

            [Display(Name = "Téléphone")]
            [Phone(ErrorMessage = "Il faut que le téléphone soit de la forme ###-###-####")]
            public string PhoneNumber {get;set;}


            [Display(Name = "Prénom du propriétaire")]
            public string OwnerFirstName {get;set;}

            [Display(Name = "Nom de famille du propriétaire")]

            public string OwnerLastName {get;set;}


            [Display(Name = "Descriptif de l'emplacement")]
            [DataType(DataType.MultilineText)]
            
            [MaxLength(1500, ErrorMessage="Maximum de 1500 caractères pour l'adresse.")]
            public string Description{get;set;}

    }
}