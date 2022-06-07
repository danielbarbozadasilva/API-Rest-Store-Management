using API_Rest_Store_Management.Data;

namespace API_Rest_Store_Management.Core.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Store> Stores { get; }
        Task Save();
    }
}