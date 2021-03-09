using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.DBModels
{
    public class Person
    {
        public Person()
        {
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Passwoord { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Pet> Pets { get; set; }
        public int? HouseId { get; set; }
        public House House { get; set; }


    }
}
