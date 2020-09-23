using System;

namespace MaisonReve.Database.Exceptions
{
    public class BuildingRepoException : Exception{

      public string Property {get;set;}
        public BuildingRepoException(string property, string message) : base(message)
        {
            this.Property = property;
        }


        public BuildingRepoException(string message) : base(message)
        {
            this.Property = "";
        }


    }


}