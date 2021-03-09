using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.DTO
{
    public class CreatePersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Passwoord { get; set; }
        public DateTime BirthDate { get; set; }
        public int? HouseId { get; set; }
    }
}
