using System.Text.Json;
using MyAppartment.Library.Interfaces;

namespace MyAppartment.BlazorServer.Services;

public class IoService : IIoService
{
    public string ReadData(string path)
    {
        return File.ReadAllText(path);
    }

    public Task<string> ReadDataAsync(string path)
    {
        return File.ReadAllTextAsync(path);
    }

    public async Task<T?> DeserializeAsync<T>(string path)
    {
        var data = await ReadDataAsync(path);

        return JsonSerializer.Deserialize<T>(data);
    }
}
