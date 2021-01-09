using Library.Core.Concrete;
using Library.DataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace Library.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfBookDal : 
        EfRepositoryBase<Book,LibraryDBContext>,
        IBookDal
    {
        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
