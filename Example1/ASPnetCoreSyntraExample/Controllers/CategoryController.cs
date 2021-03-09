using ASPnetCoreSyntraExample.Db;
using ASPnetCoreSyntraExample.DTO;
using ASPnetCoreSyntraExample.Models;
using ASPnetCoreSyntraExample.Services;
using ASPnetCoreSyntraExample.Services.Interfaces;
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
    public partial class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpPost]
        public ActionResult<Category> CreateNewCategory(CreateCategoryDTO createCategoryDTO)
        {
            var newCategory = new Category();
            newCategory.Name = createCategoryDTO.Name;
            var categoryFromDB = _categoryService.AddCategory(newCategory);
            return Ok(categoryFromDB);
        }


        [HttpGet("many")]
        public ActionResult<List<ResponseCategoryDTO>> GetAllCategories()
        {
            var categories = _categoryService.GetCategories();
            var listOfResponseCategoryDTO = new List<ResponseCategoryDTO>();
            foreach (var cat in categories)
            {
                var responseCategoryDTO = new ResponseCategoryDTO();
                responseCategoryDTO.Id = cat.Id;
                responseCategoryDTO.Name = cat.Name;
                listOfResponseCategoryDTO.Add(responseCategoryDTO);
            }

            return Ok(listOfResponseCategoryDTO);
        }
        [HttpGet("manywithproducts")]
        public ActionResult<List<ResponseCategoryWithProductsDTO>> GetAllCategoriesWithProducts()
        {
            var categories = _categoryService.GetCategoriesWithProducts();
            var listOfResponseCategoryDTO = _mapper.Map<List<ResponseCategoryWithProductsDTO>>(categories);
            return Ok(listOfResponseCategoryDTO);
        }
        [HttpGet("manywithproductsthatcrashes")]
        public ActionResult<List<Category>> GetAllCategoriesWithProductsWITHOUTDTO()
        {
            var categories = _categoryService.GetCategoriesWithProducts();
            return Ok(categories);
        }
        [HttpGet("GetCategoriesWithTotalPrice")]
        public ActionResult<List<CategoriesWithTotalPriceDTO>> GetCategoriesWithTotalPrice()
        {
            var allcatswithproducts = _categoryService.GetCategoriesWithProducts();
            var returnList = new List<CategoriesWithTotalPriceDTO>();
            foreach (var cat in allcatswithproducts)
            {
                var catwithTotalPrice = new CategoriesWithTotalPriceDTO();
                catwithTotalPrice.CategoryName = cat.Name;
                int totalPriceOfCat = 0;
                foreach (var prod in cat.Products)
                {
                    totalPriceOfCat = totalPriceOfCat + prod.Price;
                }
                catwithTotalPrice.CategoryTotalPrice = totalPriceOfCat;
                returnList.Add(catwithTotalPrice);
            }


            return Ok(returnList);
        }
        //[HttpGet("one")]
        //public ActionResult<House> GetHouse(string houseName)
        //{
        //    var house = _houseService.GetHouse(houseName);
        //    if (house == null)
        //    {
        //        return NotFound();

        //    }
        //    return Ok(house);
        //}

        //[HttpDelete]
        //public ActionResult DeleteHouseById(int houseId)
        //{
        //    _houseService.DeleteHouseById(houseId);
        //    return Ok();
        //}

        //[HttpPut]
        //public ActionResult<House> UpdateHouseById(int houseIdToEdit, House houseEditValues)
        //{
        //    var updatedHouse = _houseService.UpDateHouseById(houseIdToEdit, houseEditValues);
        //    return Ok(updatedHouse);


        //}

    }
}
