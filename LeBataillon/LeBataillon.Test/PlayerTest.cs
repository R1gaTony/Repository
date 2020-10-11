using System;
using Xunit;
using LeBataillon.Database.Models;
using Moq;
using System.Linq;
using LeBataillon.Database.MockData;
using Microsoft.AspNetCore.Mvc;
using LeBataillon.Web.Controllers;
using System.Collections.Generic;
using LeBataillon.Database.Repository;

namespace LeBataillon.Test
{
    public class PlayerTest
    {

        [Fact]
        public void PlayerIndex_Test()
        {
            //Arrange
            var MockRepo = new Mock<PlayerRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayersController(MockRepo.Object);

            //act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void PlayerIndexList_Test()
        {
            //Arrange
            var MockRepo = new Mock<PlayerRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayersController(MockRepo.Object);

            //act
            var result = controller.Index();

            //Assert
            var ViewResult = result as IActionResult;
            Assert.IsAssignableFrom<List<Player>>(ViewResult.ToString());
        }
        [Fact]
          public void PlayerIndexNombre_Test()
        {
            //arrange
            var MockRepo = new Mock<PlayerRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayersController(MockRepo.Object);

            //act
            var result = controller.Index();

            //assert
            var viewResult = result as IActionResult;
            var viewResultPlayer = viewResult as List<Player>;
            Assert.Equal(30, viewResultPlayer.Count);
        }

        [Fact]
        public void Create()
        {

        }
 
    }
}
