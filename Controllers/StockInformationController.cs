using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockInformationController : Controller
    {
        private readonly IStockInformationRepository _stockInformationRepository;

        public StockInformationController( IStockInformationRepository stockInformationRepository)
        {
            _stockInformationRepository = stockInformationRepository;
        }
        public IActionResult Index()
        {
            var data  = _stockInformationRepository.GetAll();

            return View(data);

        }
    }
}
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
