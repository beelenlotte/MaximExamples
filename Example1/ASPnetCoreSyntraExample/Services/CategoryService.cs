using ASPnetCoreSyntraExample.Db;
using ASPnetCoreSyntraExample.Models;
using ASPnetCoreSyntraExample.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPnetCoreSyntraExample.Services
{
    public class CategoryService : ICategoryService
    {
        public Category AddCategory(Category category)
        {
            using (var db = new GodDbContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return category;
            }
        }
        public List<Category> GetCategories()
        {
            using (var db = new GodDbContext())
            {
                var listOfCatgories = db.Categories.ToList();
                return listOfCatgories;
            }
        }
        public List<Category> GetCategoriesWithProducts()
        {
            using (var db = new GodDbContext())
            {
                var listOfCatgories = db.Categories.Include(x=>x.Products).ToList();
                return listOfCatgories;
            }
        }
        //public Category GetCategory(string CategoryName)
        //{
        //    using (var db = new GodDbContext())
        //    {
        //        var Category = db.Categories.FirstOrDefault(Category => Category.Name == CategoryName);
        //        return Category;
        //    }
        //}

        //public List<Category> GetCategorys()
        //{
        //    using (var db = new GodDbContext())
        //    {
        //        return db.Categories.ToList();
        //    }
        //}
        //public void DeleteCategoryById(int CategoryId)
        //{
        //    using (var db = new GodDbContext())
        //    {
        //        var CategoryToDelete = db.Categories.FirstOrDefault(Category => Category.Id == CategoryId);
        //        db.Categories.Remove(CategoryToDelete);
        //        db.SaveChanges();
        //    }
        //}

        //public Category UpDateCategoryById(int CategoryIdToEdit, Category CategoryEditValues)
        //{
        //    using (var db = new GodDbContext())
        //    {
        //        var CategoryToEdit = db.Categories.First(Category => Category.Id == CategoryIdToEdit);
        //        CategoryToEdit.Price = CategoryEditValues.Price;
        //        CategoryToEdit.CategoryId = CategoryEditValues.CategoryId;
        //        CategoryToEdit.Name = CategoryEditValues.Name;
        //        db.Categories.Update(CategoryToEdit);
        //        db.SaveChanges();
        //        return CategoryToEdit;
        //    }
        //}
    }
}
