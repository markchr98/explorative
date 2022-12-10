public interface IConfigLoader<T> {
    Task<T?> loadConfig();
}