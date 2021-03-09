using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.DBModels
{

    // Get var petWithPerson =  db.Pets.FirstOrDefault(x=>x.Id == 5).Include(x=>x.Person);



    // ZONDER INCLUDE
    //var pet = db.Pets.FirstOrDefault(x=>x.Id == 5) // SQL // select * from db.pets where Id = 5 top 1;


    // MET INCLUDE
    // var petWithPerson =  db.Pets.FirstOrDefault(x=>x.Id == 5).Include(x=>x.Person) 
    // SQL 
    // select db.pets.*, db.persons.* from db.pets inner join db.pets.personid = db.person.id where Id = 5 top 1;

    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public PetTypes PetType { get; set; }
        public int PersonId { get; set; } // Dit gebeurt automatisch doordat we een many verwijzing hebben vanuit Person naar deze class.
        public Person Person { get; set; }
    }
}
