using AutoMapper;
using FluentAssertions;
using Moq;
using QuickBase.Business.Dtos;
using QuickBase.Business.Interfaces.External;
using QuickBase.Business.Interfaces.Helpers;
using QuickBase.Business.Interfaces.SqliteData;
using QuickBase.Business.Services;
using System.Collections.Generic;
using Xunit;

namespace QuickBase.UnitTests
{
    /// <summary>Unit test for cheking if GetCountriesNamesForRemoval method is working as expected.</summary>
    public class GetCountriesNamesForRemovalTest
    {
        [Fact]
        public void Should_ReturnListOfCountriesNamesForRemoval()
        {
            //Arrange
            const string duplicatedCountryName = "U.S.A.";

            var countryChecklist = new List<string>
            {
                "Bulgaria",
                duplicatedCountryName,
                "United Kingdom"
            };

            var countryExternalList = new List<CountryDto>
            {
                new CountryDto
                {
                    Id = 5,
                    Name = duplicatedCountryName,
                    Population = 330000000
                }
            };

            var statServiceMock = new Mock<IStatService>();
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            var countryNameHelperMock = new Mock<ICountryNamesHelper>();
            var mapperMock = new Mock<IMapper>();
            var countryService = new CountryService(unitOfWorkMock.Object, mapperMock.Object, statServiceMock.Object, countryNameHelperMock.Object);

            //Act
            var result = countryService.GetCountriesNamesForRemoval(countryChecklist, countryExternalList);

            //Assert
            result.Should().HaveCount(1).And.ContainSingle(x => x == duplicatedCountryName);
        }
    }
}
