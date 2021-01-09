using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Library.Business.Abstract;
using Library.DataAccess.Abstract;
using Library.Entities.Concrete;

namespace Library.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetAll(filter);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Get(filter);
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }
    }
}