using AutoMapper;
using Example2.DBModels;
using Example2.DTO.Pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.Profiles
{
    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<Pet, GetPetDTO>().ReverseMap();
        }
    }
}
