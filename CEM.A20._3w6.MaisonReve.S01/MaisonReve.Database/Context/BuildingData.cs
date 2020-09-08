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
          var name = "Le Super " + SampleData.GenerateName();
            Data.Add(new Building(i, name, SampleData.GenerateAddress(), SampleData.GeneratePhoneNumber(),SampleData.GenerateName(), SampleData.GenerateLastName(), $"{name} est un immeuble extra, où il fait bon vivre!"));
        } 
    }
 }



}
