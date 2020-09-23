using System.Collections.Generic;
using MaisonReve.Database.Initializer.DataFixtures;
using MaisonReve.Database.Models;

namespace MaisonReve.Database.Context
{
    public  class BuildingStaticData {

     public  List<Building> Data = new List<Building>();

     public void EnsureCreated(){

        for (int i = 1; i < 200; i++)
        {
          var name = "Le Super " + SampleData.GenerateName(i);
            Data.Add(new Building(i, name, SampleData.GenerateAddress(i), SampleData.GeneratePhoneNumber(i),SampleData.GenerateName(i+1), SampleData.GenerateLastName(i+1), $"{name} est un immeuble extra, où il fait bon vivre!"));
         } 
    }
 }



}
