using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiForAngular.Entity.Interfaces;

namespace WebApiForAngular.DataAccess.Interfaces
{
    public interface IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Uptade(TEntity entity);
        Task Add(TEntity entity);
        Task Remove(TEntity entity);
    }
}
