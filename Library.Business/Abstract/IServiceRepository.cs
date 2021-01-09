﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library.Business.Abstract
{
    public interface IServiceRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
