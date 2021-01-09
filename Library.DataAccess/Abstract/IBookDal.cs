using Library.Core.Concrete;

namespace Library.DataAccess.Abstract
{
    public interface IBookDal : 
        IEntityRepository<Book>,IADORepository<Book>
    {

    }
}
