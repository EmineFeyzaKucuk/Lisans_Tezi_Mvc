using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository { 

    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public TEntity Add(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Add(entity);
            _appDbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            TEntity entity = new TEntity { Id = id };
            _appDbContext.Set<TEntity>().Remove(entity);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            var data = _appDbContext.Set<TEntity>().ToList();
            return data;
        }

        public TEntity GetById(int id)
        {
            return _appDbContext.Set<TEntity>().First(x => x.Id == id);
        }

        public void Update(TEntity entity, int id)
        {
            _appDbContext.Set<TEntity>().Update(entity);
            _appDbContext.SaveChanges();
        }
    }

}
