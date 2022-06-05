namespace API_Rest_Store_Management.Core.Services
{
    public interface IAuthManager
    {
        Task<string> CreateToken();
    }
}