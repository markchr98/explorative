using System.Linq.Expressions;

public class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
    private readonly IRepositoryContext<T> _repositoryContext;

    public BaseRepository(IRepositoryContext<T> repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<T>?> Find(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task<T?> Get(int id)
    {
       var data = await _repositoryContext.fetchData();
       if (data is null) {
        return null;
       }
       return data.FirstOrDefault<T>(d => d.id == id);
    }

    public async Task<IEnumerable<T>?> GetAll()
    {
        var data = await _repositoryContext.fetchData();
       if (data is null) {
        return null;
       }
       return data;
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }
}