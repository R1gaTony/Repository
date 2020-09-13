using System;
using Xunit;
using ZombiesPartyPersonas;

namespace ZombiesParty_Tests
{
    public class ChasseurAttaque_Tests
    {
        [Fact]
        public void Attaque_PtsVieSuffisant()
        {
            //Arrange
            Chasseur chasseur = new Chasseur();
            Zombie zombie = new Zombie(){
                PointsDeVie = 100
            };

            //Act
            chasseur.Attaquer(zombie);

            //Assert
            Assert.True(zombie.PointsDeVie==50);
        }

        [Fact]
        public void Attaque_PtsVieInsuffisant()
        {
            //Arrange
            Chasseur chasseur = new Chasseur();
            Zombie zombie = new Zombie(){
                PointsDeVie = 30
            };

            //Act
            chasseur.Attaquer(zombie);

            //Assert
            Assert.True(zombie.PointsDeVie==0);
        }

        [Fact]
        public void Attaque_PtsVieInexistant()
        {
            //Arrange
            Chasseur chasseur = new Chasseur();
            Zombie zombie = null;       

            //Act
            chasseur.Attaquer(zombie);

            //Assert
            Assert.Null(zombie);
        }
    }
}
