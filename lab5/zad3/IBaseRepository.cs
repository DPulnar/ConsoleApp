using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad3
{
    public interface IBaseRepository<T, TEntity> where T : IEntity<TEntity>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(int entity);
        List<T> GetAll();
        T Get(TEntity id);
    }
}
