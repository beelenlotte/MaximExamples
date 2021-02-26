using ASPnetCoreSyntraExample.Models;
using System.Collections.Generic;

namespace ASPnetCoreSyntraExample.Services
{
    public interface IHouseService
    {
        House GetHouse(string houseName);
        List<House> GetHouses();
        void AddHouse(House house);
        void DeleteHouseById(int houseId);
        House UpDateHouseById(int houseIdToEdit, House houseEditValues);
    }
}
