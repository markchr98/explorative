public interface IRepositoryContext<T> {
    public Task<IEnumerable<T>?> fetchData();
}