using ASPnetCoreSyntraExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPnetCoreSyntraExample.Services
{
    public class HouseService : IHouseService
    {
        public List<House> houses = new List<House>();

        public HouseService()
        {
            if (houses.Count == 0)
            {
                var house1 = new House();
                house1.Name = "H1";
                house1.Area = "100m2";
                house1.Price = 100000;
                houses.Add(house1);
            }
        }
        public House GetHouse(string houseName)
        {
            var house = houses.FirstOrDefault(x => x.Name == houseName);
            return house;
        }
        public List<House> GetHouses()
        {
            return houses;
        }
        public void AddHouse(House house)
        {
            Console.WriteLine("Add the house yes yes");
            //houses.Add(house);
        }
        public void DeleteHouseById(int houseId)
        {
            throw new NotImplementedException();
        }
        public House UpDateHouseById(int houseIdToEdit, House houseEditValues)
        {
            throw new NotImplementedException();
        }
    }
}
