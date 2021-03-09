using Example2.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.DTO.Pet
{
    public class GetPetDTO
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public PetTypes PetType { get; set; }
    }
}
