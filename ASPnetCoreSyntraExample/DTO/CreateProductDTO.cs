namespace ASPnetCoreSyntraExample.Controllers
{
    public partial class ProductController
    {
        public class CreateProductDTO // DTO = Data Transfer Object
        {
            public string Name { get; set; }
            public string HiddenCode { get; set; }
            public int Price { get; set; }
            public int CategoryId { get; set; }

        }

    }
}
