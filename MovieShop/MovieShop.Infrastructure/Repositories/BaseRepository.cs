using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Interfaces.Repositories;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repositories;

public class BaseRepository<T> : IRepository<T> where T : class
{
    private readonly MovieShopDbContext _dbContext;

    public BaseRepository(MovieShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual T GetById(int id)
    {
        return _dbContext.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _dbContext.Set<T>().ToList();
    }

    public int Insert(T entity)
    {
        _dbContext.Set<T>().Add(entity);
        return _dbContext.SaveChanges();
    }

    public int Update(T entity)
    {
        _dbContext.Set<T>().Entry(entity).State = EntityState.Modified;
        return _dbContext.SaveChanges();
    }

    public int Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            _dbContext.Set<T>().Remove(entity);
            return _dbContext.SaveChanges();
        }
        return 0;
    }
}