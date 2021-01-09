using System.Collections.Generic;

namespace Library.DataAccess.Abstract
{
    public interface IADORepository<T>
    {
        List<T> GetAll();
        T Get(int id);
    }
}
