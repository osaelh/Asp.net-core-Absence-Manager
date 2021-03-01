using AbsenceManager.Contract;
using AbsenceManager.Controllers;
using AbsenceManager.Data;
using AbsenceManager.Models;
using AutoMapper;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AbsenceManager.Tests
{
   public class AbsenceTypeTests
    {
        [Fact]
        public void Index_ReturnsViewResultWith()
        {
            //Arrange
            var AbsenceTypes = new List<AbsenceType>();
            var AbsenceType = new AbsenceType
            {
                Id = 1,
                Name="Sick",
                DefaultDays=3,
                DateCreated=DateTime.Now

            };
            AbsenceTypes.Add(AbsenceType);
            var AbsenceTypesVm = new List<DetailsAbsenceTypeViewModel>();
            var AbsenceTypeVm = new DetailsAbsenceTypeViewModel
            {
                Id = 1,
                Name = "Sick",
                DefaultDays = 3,
                DateCreated = DateTime.Now

            };
            AbsenceTypesVm.Add(AbsenceTypeVm);
            var mockMapper = new Mock<IMapper>();
            mockMapper.Setup(s => s.Map<List<AbsenceType>, List<DetailsAbsenceTypeViewModel>>(AbsenceTypes))
                .Returns(AbsenceTypesVm);
            var mockRepo = new Mock<IAbsenceTypeRepository>();
            mockRepo.Setup(s => s.GetAll()).Returns(AbsenceTypes);
            var controller = new AbsenceTypeController(mockRepo.Object,mockMapper.Object);

            //Act
            var result = controller.Index();
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.Model);

        }


    }
}
