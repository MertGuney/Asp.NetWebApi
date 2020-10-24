﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiForAngular.Entity.Interfaces;

namespace WebApiForAngular.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Update(TEntity entity);
        Task Add(TEntity entity);
        Task Remove(TEntity entity);
    }
}