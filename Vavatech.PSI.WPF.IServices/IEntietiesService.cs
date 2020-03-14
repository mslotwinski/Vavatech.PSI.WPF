using System.Collections.Generic;
using System.Threading.Tasks;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.IServices
{
    public interface IEntietiesService<TEntity> where TEntity:Base
    {
        IList<TEntity> Get();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        Task<IList<TEntity>> GetAsync();
    }
}