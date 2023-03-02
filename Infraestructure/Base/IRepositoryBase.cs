﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Base
{
    public interface IRepositoryBase<T, K>
    {
        Task<T> Create(T entity);
        Task<T?> Edit(K id, T entity);
        Task<T?> EnableOrDisable(K id);
        Task<T?> Find(K id);
        Task<IList<T>> FindAll();
    }
}
