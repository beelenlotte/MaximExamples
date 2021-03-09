using ASPnetCoreSyntraExample.Models;
using ASPnetCoreSyntraExample.Services;
using System;
using Xunit;

namespace ASPnetCoreSyntraExample.Tests
{
    public class HousServiceTests
    {
        [Fact]
        public void AddHouse_AddHouseToList()
        {
            var houseService = new HouseService();
            var testHouse = new House();
            testHouse.Id = 1;
            testHouse.Name = "testhuisje";
            houseService.AddHouse(testHouse);

            var result = houseService.houses.Contains(testHouse);

            Assert.True(result, "House is added to the list!");
        }



    }
}
