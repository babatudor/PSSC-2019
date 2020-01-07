using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Business.Domain;
using System.Threading.Tasks;

namespace Business.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        //define generic crud functions 
        IEnumerable<TEntity> getAll();

        //iQueryable<TEntity> getALL();
        Task<TEntity> getById(int id);
        Task Create(TEntity entity);
        Task Update(int id,TEntity entity);
        Task Delete(int id);
    }
}
