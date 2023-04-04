using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity,new()
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity Add(TEntity entity);

        void Update(TEntity entity,int id);

        void Delete(int id);


    }
}
