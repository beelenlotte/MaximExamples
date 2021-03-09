using AutoMapper;
using Example2.DBModels;
using Example2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<CreatePersonDTO, Person>().ReverseMap();
        }
    }
}
