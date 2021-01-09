using Library.DataAccess.Abstract;
using Library.Entities.Concrete;

namespace Library.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal : EfRepositoryBase<Category, LibraryDBContext>, ICategoryDal
    {

    }
}
