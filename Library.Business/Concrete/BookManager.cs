using Library.Business.Abstract;
using Library.Core.Concrete;
using Library.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library.Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            return _bookDal.GetAll(filter);
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            return _bookDal.Get(filter);
        }
        

        public void Add(Book entity)
        {
            _bookDal.Add(entity);
        }

        public void Update(Book entity)
        {
            _bookDal.Update(entity);
        }

        public void Delete(Book entity)
        {
            _bookDal.Delete(entity);
        }
    }
}
