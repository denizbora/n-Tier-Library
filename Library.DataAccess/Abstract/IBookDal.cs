using Library.Entities.Concrete;

namespace Library.DataAccess.Abstract
{
    public interface IBookDal : 
        IEntityRepository<Book>,IADORepository<Book>
    {

    }
}
