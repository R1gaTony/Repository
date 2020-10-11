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
    public class GameTest
    {
        [Fact]
        public void GameIndex_Test()
        {
            //Arrange
            var MockRepo = new Mock<GameRepository>();
            MockRepo.Setup(n => n.GetAll().Returns(GameMockData.GetGamesTest()));
            var controller = new GamesController(MockRepo.Object);

            //act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void GameIndexList_Test()
        {
            //Arrange
            var MockRepo = new Mock<GameRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(GameMockData.GetGamesTest());
            var controller = new GamesController(MockRepo.Object);

            //act
            var result = controller.Index();

            //Assert
            var ViewResult = result as IActionResult;
            Assert.IsAssignableFrom<List<Player>>(ViewResult.ToString());
        }
        [Fact]
          public void GameIndexNombre_Test()
        {
            //arrange
            var MockRepo = new Mock<GameRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(GameMockData.GetGamesTest());
            var controller = new GamesController(MockRepo.Object);

            //act
            var result = controller.Index();

            //assert
            var viewResult = result as IActionResult;
            var viewResultGame = viewResult as List<Game>;
            Assert.Equal(3, viewResultGame.Count);
        }
    }
}