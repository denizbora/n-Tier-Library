using System.Collections.Generic;
using Library.DataAccess.Abstract;
using Library.Entities.Concrete;

namespace Library.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal : EfRepositoryBase<Category, LibraryDBContext>, ICategoryDal
    {
        public List<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
