using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeBataillon.Database.Models
{
    public class Player
    {
        public Player()
        {


        }

        public Player(int Id, string NickName, string Email, string PhoneNumber, string FirstName, string LastName, PlayerLevel level)
        {           
            this.Id = Id;
            this.NickName = NickName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Level = Level;

        } 

        public void EditFrom(Player p)
        {
            this.Id = p.Id;
            this.NickName = p.NickName;
            this.Email = p.Email;
            this.PhoneNumber = p.PhoneNumber;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Level = p.Level;
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        
        public string NickName { get; set; }

        [Required(ErrorMessage = "Le Email est requis")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Le FirstName est requis")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le LastName est requis")]
        public string LastName { get; set; }

        public PlayerLevel Level { get; set; }

        public int TeamId {get;set;}

        public virtual Team Team {get; set;}

        // public List<Team> ListTeam;
        // public virtual Team 

        public static implicit operator Player(int v)
        {
            throw new NotImplementedException();
        }
    }
}