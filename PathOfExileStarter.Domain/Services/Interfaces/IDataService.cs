namespace PathOfExileStarter.Domain.Services.Interfaces
{
    internal interface IDataService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<T> GetAsync<T>(int id);
    }
}
