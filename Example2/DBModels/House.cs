using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.DBModels
{
    public class House
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Postal { get; set; }
        public string Town { get; set; }
    }
}
