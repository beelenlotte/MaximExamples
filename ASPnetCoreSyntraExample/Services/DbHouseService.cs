using ASPnetCoreSyntraExample.Db;
using ASPnetCoreSyntraExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPnetCoreSyntraExample.Services
{
    public class DbHouseService : IHouseService
    {
        public void AddHouse(House house)
        {
            using (var db = new GodDbContext())
            {
                db.Houses.Add(house);
                db.SaveChanges();
            }
        }
        public House GetHouse(string houseName)
        {
            using (var db = new GodDbContext())
            {
                var house = db.Houses.FirstOrDefault(house => house.Name == houseName);
                return house;
            }
        }

        public List<House> GetHouses()
        {
            using (var db = new GodDbContext())
            {
                return db.Houses.ToList();
            }
        }
        public void DeleteHouseById(int houseId)
        {
            using (var db = new GodDbContext())
            {
                var houseToDelete = db.Houses.FirstOrDefault(house => house.Id == houseId);
                db.Houses.Remove(houseToDelete);
                db.SaveChanges();
            }
        }

        public House UpDateHouseById(int houseIdToEdit, House houseEditValues)
        {
            using (var db = new GodDbContext())
            {
                var houseToEdit = db.Houses.First(house => house.Id == houseIdToEdit);
                houseToEdit.Price = houseEditValues.Price;
                houseToEdit.Area = houseEditValues.Area;
                houseToEdit.Name = houseEditValues.Name;
                db.Houses.Update(houseToEdit);
                db.SaveChanges();
                return houseToEdit;
            }
        }
    }
}
