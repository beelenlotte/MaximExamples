using ASPnetCoreSyntraExample.Db;
using ASPnetCoreSyntraExample.Models;
using ASPnetCoreSyntraExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPnetCoreSyntraExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public partial class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }
        [HttpGet("many")]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var Products = _ProductService.GetProducts();
            return Ok(Products);
        }
        [HttpGet("one")]
        public ActionResult<Product> GetProduct(string ProductName)
        {
            var Product = _ProductService.GetProduct(ProductName);
            if (Product == null)
            {
                return NotFound();

            }
            return Ok(Product);
        }
        [HttpPost]
        public ActionResult CreateNewProduct(CreateProductDTO createProductDTO)
        {
            var productToInsertInDB = new Product();
            productToInsertInDB.Name = createProductDTO.Name;
            productToInsertInDB.HiddenCode = createProductDTO.HiddenCode;
            productToInsertInDB.Price = createProductDTO.Price;
            productToInsertInDB.CategoryId = createProductDTO.CategoryId;
            _ProductService.AddProduct(productToInsertInDB);
            return Ok();
        }


        [HttpDelete]
        public ActionResult DeleteProductById(int ProductId)
        {
            _ProductService.DeleteProductById(ProductId);
            return Ok();
        }


        [HttpPut]
        public ActionResult<Product> UpdateProductById(int productIdToEdit, Product productEditValues)
        {
            var updatedProduct = _ProductService.UpDateProductById(productIdToEdit, productEditValues);
            return Ok(updatedProduct);


        }

    }
}
