using System.Collections.Generic;

namespace ASPnetCoreSyntraExample.Controllers
{
    public partial class CategoryController
    {
        public class ResponseCategoryWithProductsDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<ResponseProductDTO> Products { get; set; }
        }








    }
}
