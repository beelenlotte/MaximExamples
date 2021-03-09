using Example2.DBModels;
using System.Collections.Generic;

namespace Example2.Services.Interfaces
{
    public interface IPersonService
    {
        void ChangePassword(string email, string currentPassword, string newPassword);
        void CreatePerson(Person person);
        void DeletePerson(int id, string email, string currentPassword);
        List<Pet> GetMyPets(int personId);
        bool Login(string email, string password);
    }
}