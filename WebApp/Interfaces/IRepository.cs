using System.Linq.Expressions;

public interface IRepository<T> where T : BaseEntity {
    Task<T?> Get(int id);
    Task<IEnumerable<T>?> GetAll();
    Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    void Add(T entity);
    void Remove(T entity);    
}