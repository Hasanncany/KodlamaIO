using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class CategoryDal:ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            Category category = new Category();
            category.Id = 1;
            category.CategoryName = "Tümü";

            Category category2 = new Category();
            category2.Id = 2;
            category2.CategoryName = "Programlama (8)";
            
            _categories = new List<Category> { category, category2};
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
            Console.WriteLine("Kategori Silindi.");
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void UpdateName(Category category)
        {
            Console.WriteLine("Kategorinin adı güncellendi.");
        }
    }
}
