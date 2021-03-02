using ASPnetCoreSyntraExample.Db;
using ASPnetCoreSyntraExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPnetCoreSyntraExample.Services
{
    public class ProductService : IProductService
    {
        public void AddProduct(Product Product)
        {
            using (var db = new GodDbContext())
            {
                db.Products.Add(Product);
                db.SaveChanges();
            }
        }
        public Product GetProduct(string ProductName)
        {
            using (var db = new GodDbContext())
            {
                var Product = db.Products.FirstOrDefault(Product => Product.Name == ProductName);
                return Product;
            }
        }

        public List<Product> GetProducts()
        {
            using (var db = new GodDbContext())
            {
                return db.Products.ToList();
            }
        }
        public void DeleteProductById(int ProductId)
        {
            using (var db = new GodDbContext())
            {
                var ProductToDelete = db.Products.FirstOrDefault(Product => Product.Id == ProductId);
                db.Products.Remove(ProductToDelete);
                db.SaveChanges();
            }
        }

        public Product UpDateProductById(int ProductIdToEdit, Product ProductEditValues)
        {
            using (var db = new GodDbContext())
            {
                var ProductToEdit = db.Products.First(Product => Product.Id == ProductIdToEdit);
                ProductToEdit.Price = ProductEditValues.Price;
                ProductToEdit.CategoryId = ProductEditValues.CategoryId;
                ProductToEdit.Name = ProductEditValues.Name;
                db.Products.Update(ProductToEdit);
                db.SaveChanges();
                return ProductToEdit;
            }
        }
    }
}
