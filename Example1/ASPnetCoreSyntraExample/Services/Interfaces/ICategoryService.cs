using ASPnetCoreSyntraExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPnetCoreSyntraExample.Services.Interfaces
{
    public interface ICategoryService
    {
        Category AddCategory(Category category);

        List<Category> GetCategories();

        List<Category> GetCategoriesWithProducts();


    }
}
