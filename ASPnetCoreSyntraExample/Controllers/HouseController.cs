using ASPnetCoreSyntraExample.Db;
using ASPnetCoreSyntraExample.Models;
using ASPnetCoreSyntraExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPnetCoreSyntraExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;
        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }
        [HttpGet("many")]
        public ActionResult<List<House>> GetAllHouses()
        {
            var houses = _houseService.GetHouses();
            return Ok(houses);
        }
        [HttpGet("one")]
        public ActionResult<House> GetHouse(string houseName)
        {
            var house = _houseService.GetHouse(houseName);
            if (house == null)
            {
                return NotFound();

            }
            return Ok(house);
        }
        [HttpPost]
        public ActionResult CreateNewHouse(House newHouse)
        {
            _houseService.AddHouse(newHouse);
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteHouseById(int houseId)
        {
            _houseService.DeleteHouseById(houseId);
            return Ok();
        }

        [HttpPut]
        public ActionResult<House> UpdateHouseById(int houseIdToEdit, House houseEditValues)
        {
            var updatedHouse = _houseService.UpDateHouseById(houseIdToEdit, houseEditValues);
            return Ok(updatedHouse);


        }

    }
}
