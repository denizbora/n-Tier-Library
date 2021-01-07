using System;
using System.Linq;
using System.Threading.Tasks;
using Library.Business.Abstract;
using Library.Business.DependencyResolvers.Ninject;
using Library.Core.Concrete;
using Library.DataAccess.Concrete.ADONET;

namespace Library.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            new ADOBookDal().GetAll().ToList().ForEach(b=>System.Console.WriteLine(b.Title));
            var book = new ADOBookDal().Get(1);
            System.Console.WriteLine(book.Title);
            new ADOCategoryDal().GetAll().ToList().ForEach(c=>System.Console.WriteLine(c.CategoryName));
            var bookService = InstanceFactory.GetInstance<IBookService>();
            bookService.GetAll().ForEach(b=>System.Console.WriteLine(b.Title));
        }
    }
}
