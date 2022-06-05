namespace API_Rest_Store_Management.Core.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save();
    }
}