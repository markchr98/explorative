using System.Net.Http.Json;

public class RepositoryContext<T> : IRepositoryContext<T> {
    
    private string DataPath { get; }
    
    private IEnumerable<T>? data;
    private HttpClient http { get; }

    public RepositoryContext(HttpClient http, string dataPath)
    {
        this.http = http;
        DataPath = dataPath;
    }
    public async Task<IEnumerable<T>?> fetchData()
    {
        if (data == null) {
            data = await this.http.GetFromJsonAsync<IEnumerable<T>>(this.DataPath);
        }
        return data;
    }
}