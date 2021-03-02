using System.ComponentModel.DataAnnotations.Schema;

namespace ASPnetCoreSyntraExample.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HiddenCode { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
