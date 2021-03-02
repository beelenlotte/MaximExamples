using ASPnetCoreSyntraExample.Models;
using System.Collections.Generic;

namespace ASPnetCoreSyntraExample.Services
{
    public interface IProductService
    {
        Product GetProduct(string ProductName);
        List<Product> GetProducts();
        void AddProduct(Product Product);
        void DeleteProductById(int ProductId);
        Product UpDateProductById(int ProductIdToEdit, Product ProductEditValues);
    }
}
