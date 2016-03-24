﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Contracts
{
    public interface IRepository<TEntity, TDto> where TEntity : class where TDto : class
    {
        void Add(TDto obj);
        void Remove(TDto obj);
        void Update(TDto obj);
        IEnumerable<TDto> GetList();
        IEnumerable<TDto> GetWithFilter(Expression<Func<TEntity, bool>> expresion);
    }
}

