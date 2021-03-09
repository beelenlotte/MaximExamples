using AutoMapper;
using Example2.DBModels;
using Example2.DTO;
using Example2.DTO.Pet;
using Example2.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }
        [HttpPost("Create")]
        public ActionResult Create(CreatePersonDTO createPersonDTO)
        {
            var personFromDTO = _mapper.Map<Person>(createPersonDTO);
            _personService.CreatePerson(personFromDTO);
            return Ok();
        }
        [HttpGet("Login")]
        public ActionResult<bool> Login(string email, string password)
        {
            return Ok(_personService.Login(email, password));
        }
        [HttpGet("ChangePassword")]
        public ActionResult ChangePassword(string email, string currentPassword, string newPassword)
        {
            try
            {
                _personService.ChangePassword(email, currentPassword, newPassword);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized();
            }
            return Ok();
        }
        [HttpDelete("Delete")]
        public ActionResult Delete(int id, string email, string currentPassword)
        {
            try
            {
                _personService.DeletePerson(id, email, currentPassword);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized();
            }
            return Ok();
        }
        [HttpGet("GetMyPets")]
        public ActionResult<List<GetPetDTO>> GetMyPets(int personId)
        {
            var pets = _personService.GetMyPets(personId);
            var convertedPets = _mapper.Map<List<GetPetDTO>>(pets);
            return Ok(convertedPets);
        }
    }
}
