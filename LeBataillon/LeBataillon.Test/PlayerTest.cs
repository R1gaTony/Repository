using System;
using Xunit;
using LeBataillon.Database.Models;

namespace LeBataillon.Test
{
    public class PlayerTest
    {
        private Player _Player;
        public PlayerTest()
        {
            _Player = new Player();
        }

        [Fact]
        public void Player_emailObligatoire(){
            //Arrange
            Player PlayerTest = new Player();
            PlayerTest.Email = null;

            //Act and Assert
            if(PlayerTest.Email != this._Player.Email)
                Assert.True(false, "Le email est obligatoire");
        }  
    }
}
