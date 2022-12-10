using System.Net.Http.Json;

public class BaseConfigLoader<T> : IConfigLoader<T> {
    
    private string DataPath { get; }
    
    private T? data;
    private HttpClient http { get; }

    public BaseConfigLoader(HttpClient http, string dataPath)
    {
        this.http = http;
        DataPath = dataPath;
    }
    public async Task<T?> loadConfig()
    {
        if (data == null) {
            data = await this.http.GetFromJsonAsync<T>(this.DataPath);
        }
        return data;
    }
}