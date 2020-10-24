using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiForAngular.DataAccess.Concrete.EntityFrameworkCore.Context;
using WebApiForAngular.DataAccess.Interfaces;
using WebApiForAngular.Entity.Interfaces;

namespace WebApiForAngular.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task Add(TEntity entity)
        {
            using var context = new WebApiForAngularContext();
            context.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            using var context = new WebApiForAngularContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            using var context = new WebApiForAngularContext();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task Remove(TEntity entity)
        {
            using var context = new WebApiForAngularContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task Uptade(TEntity entity)
        {
            using var context = new WebApiForAngularContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
