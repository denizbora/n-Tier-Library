using Library.Business.Abstract;
using Library.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Library.Entities.Concrete;

namespace Library.BlazorApp.Data
{
    public  class BookServices
    {
        public Task<List<Book>> GetBooksAsync()
        {
            var bookService = InstanceFactory.GetInstance<IBookService>();
            return Task.FromResult(bookService.GetAll().ToList());
        }
        public Task<List<Category>> GetCategoryAsync()
        {
            var categoryService = InstanceFactory.GetInstance<ICategoryService>();
            return Task.FromResult(categoryService.GetAll().ToList());
        }
        public Task<Book> GetBookAsync(int id)
        {
            Expression<Func<Book, bool>> BId = book => book.Id==id; 
            var bookService = InstanceFactory.GetInstance<IBookService>();
            return Task.FromResult(bookService.Get(BId));
        }
    }
}
