using Library.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Abstract
{
    public interface IBookService:IServiceRepository<Book>
    {
    }
}
