using API_Rest_Store_Management.Core.IRepository;
using API_Rest_Store_Management.Data;

namespace API_Rest_Store_Management.Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Product> _products;
        private IGenericRepository<Store> _stores;


        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Product> Products => _products ??= new GenericRepository<Product>(_context);
        public IGenericRepository<Store> Stores => _stores ??= new GenericRepository<Store>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}