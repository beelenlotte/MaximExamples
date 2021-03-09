using ASPnetCoreSyntraExample.Db;
using ASPnetCoreSyntraExample.DTO;
using ASPnetCoreSyntraExample.Models;
using ASPnetCoreSyntraExample.Services;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public ProductController(IMapper mapper, IProductService ProductService)
        {
            _mapper = mapper;
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
            var product = _mapper.Map<Product>(createProductDTO);
            _ProductService.AddProduct(product);
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
