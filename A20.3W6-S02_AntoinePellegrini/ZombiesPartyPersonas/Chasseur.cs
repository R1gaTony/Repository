using System;
using System.Collections.Generic;
using System.Text;

namespace ZombiesPartyPersonas
{
 public class Chasseur
  {
    public int PointsDeVie { get; set; }
public void Attaquer(Zombie zombie)
    {
      if(zombie == null)
      {
        Console.WriteLine("On ne peut pas attaquer un zombie fantôme!");
      }
      else if(zombie.PointsDeVie < 50)
      {
        zombie.PointsDeVie = 0;
      }      
      else{
        zombie.PointsDeVie -=50;
      }    
    }
   
  }
}