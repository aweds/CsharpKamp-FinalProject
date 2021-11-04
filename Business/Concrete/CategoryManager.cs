using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorDal;

        public CategoryManager(ICategoryDal categorDal)
        {
            _categorDal = categorDal;
        }

        public List<Category> GetAll()
        {
            return _categorDal.GetAll();
        }

        // select * from Categories where categoryId = id
        public Category GetById(int id)
        {
            return _categorDal.Get(p => p.CategoryId == id);
        }
    }
}
