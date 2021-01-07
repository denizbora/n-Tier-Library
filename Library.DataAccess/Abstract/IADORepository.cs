using System;
using System.Collections.Generic;
using System.Text;
using Library.Core.Concrete;

namespace Library.DataAccess.Abstract
{
    public interface IADORepository<T>
    {
        List<T> GetAll();
        T Get(int id);
    }
}
