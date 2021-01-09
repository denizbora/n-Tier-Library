using Library.Core.Concrete;
using Library.DataAccess.Abstract;

namespace Library.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal : EfRepositoryBase<Category, LibraryDBContext>, ICategoryDal
    {

    }
}
