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
    public class TeamTest
    {
        [Fact]
        public void PlayerIndex_Test()
        {
            //Arrange
            var MockRepo = new Mock<TeamRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamsController(MockRepo.Object);

            //act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void PlayerIndexList_Test()
        {
            //Arrange
            var MockRepo = new Mock<TeamRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamsController(MockRepo.Object);

            //act
            var result = controller.Index();

            //Assert
            var ViewResult = result as IActionResult;
            Assert.IsAssignableFrom<List<Team>>(ViewResult.ToString());
        }
        [Fact]
          public void BuildingIndexNombre_Test()
        {
            //arrange
            var MockRepo = new Mock<TeamRepository>();
            MockRepo.Setup(n => n.GetAll()).Returns(TeamMockData.GetTeamsTest());
            var controller = new TeamsController(MockRepo.Object);

            //act
            var result = controller.Index();

            //assert
            var viewResult = result as IActionResult;
            var viewResultTeam = viewResult as List<Team>;
            Assert.Equal(5, viewResultTeam.Count);
        }
    }
}