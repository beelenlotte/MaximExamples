using Example2.DataAccess;
using Example2.DBModels;
using Example2.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.Services
{
    public class PersonService : IPersonService
    {
        public void CreatePerson(Person person)
        {
            using (var db = new Example2DbContext())
            {
                db.Persons.Add(person);
                db.SaveChanges();
            }
        }
        public bool Login(string email, string password)
        {
            using var db = new Example2DbContext();
            var personByEmail = db.Persons.FirstOrDefault(person => person.Email == email);
            if (personByEmail.Passwoord == password)
            {
                return true;
            }
            return false;
        }
        public void ChangePassword(string email, string currentPassword, string newPassword)
        {
            using var db = new Example2DbContext();
            var currentUserByEmailAndPw = db.Persons.FirstOrDefault(x => x.Email == email && x.Passwoord == currentPassword);
            if (currentUserByEmailAndPw != null)
            {
                currentUserByEmailAndPw.Passwoord = newPassword;
                db.Persons.Update(currentUserByEmailAndPw);
                db.SaveChanges();
            }
            else
            {
                throw new UnauthorizedAccessException("invalid email and/or currentpassword");
            }
        }
        public void DeletePerson(int id, string email, string currentPassword)
        {
            using var db = new Example2DbContext();
            var currentUserByEmailAndPwAndId = db.Persons
                .FirstOrDefault(x => x.Email == email && x.Passwoord == currentPassword && x.Id == id);
            if (currentUserByEmailAndPwAndId != null)
            {
                db.Persons.Remove(currentUserByEmailAndPwAndId);
                db.SaveChanges();
            }
            else
            {
                throw new UnauthorizedAccessException("invalid email and/or currentpassword and/or id");
            }
        }

        public List<Pet> GetMyPets(int personId)
        {
            using var db = new Example2DbContext();
            // get person, join the pets
            //var personWithPets = db.Persons.Include(x => x.Pets).FirstOrDefault(x => x.Id == personId);
            //return personWithPets.Pets;

            // haal alle pets met de juiste personid op
            var listOfPets = db.Pets.Where(x => x.PersonId == personId).ToList();
            return listOfPets;
        }

    }
}
