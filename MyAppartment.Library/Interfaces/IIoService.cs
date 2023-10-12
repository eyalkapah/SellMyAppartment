namespace MyAppartment.Library.Interfaces;

public interface IIoService
{
    string ReadData(string path);
    Task<string> ReadDataAsync(string path);
    Task<T?> DeserializeAsync<T>(string path);
}