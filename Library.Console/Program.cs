using System;
using System.Linq;
using Library.Business.Abstract;
using Library.Business.DependencyResolvers.Ninject;
using Library.DataAccess.Concrete.ADONET;

namespace Library.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new ADOBookDal().GetAll().ToList().ForEach(b=>Console.WriteLine(b));
            var book = new ADOBookDal().Get(1);
            Console.WriteLine(book);
            new ADOCategoryDal().GetAll().ToList().ForEach(c=>Console.WriteLine(c));
            var bookService = InstanceFactory.GetInstance<IBookService>();
            bookService.GetAll().ForEach(b=>Console.WriteLine(b));
        }
    }
}
