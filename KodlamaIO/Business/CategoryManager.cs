using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business
{
    public class CategoryManager : ICategoryDal
    {
        private readonly CategoryDal _categoryDal;
        public CategoryManager(CategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int id)
        {
            _categoryDal.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void UpdateName(Category category)
        {
            _categoryDal.UpdateName(category);
        }
    }
}
