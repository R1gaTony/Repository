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
            var MockRepo = new Mock<IPlayerRepository>();
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
            var MockRepo = new Mock<IPlayerRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayersController(MockRepo.Object);

            //act
            var result = controller.Index();

            //Assert
            var viewResult = result as ViewResult;
            Assert.IsAssignableFrom<List<Player>>(viewResult.ViewData.Model);
        }
        [Fact]
          public void PlayerIndexNombre_Test()
        {
            //arrange
            var MockRepo = new Mock<IPlayerRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayersController(MockRepo.Object);

            //act
            var result = controller.Index();

            //assert
            var viewResult = result as ViewResult;
            var viewResultBuildings = viewResult.ViewData.Model as List<Player>;
            Assert.Equal(30, viewResultBuildings.Count);
        }
 
    }
}
