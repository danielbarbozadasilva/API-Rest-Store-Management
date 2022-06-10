using API_Rest_Store_Management.Core.DTOs;
using API_Rest_Store_Management.Core.Models;

namespace API_Rest_Store_Management.Core.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
        Task<string> CreateRefreshToken();
        Task<TokenRequest> VerifyRefreshToken(TokenRequest request);
    }
}