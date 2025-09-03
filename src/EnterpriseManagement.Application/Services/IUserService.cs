using EnterpriseManagement.Application.DTOs;
namespace EnterpriseManagement.Application.Services
{
    public interface IUserService
    {
        Task<UserDto?> AuthenticateAsync(LoginDto dto);
        Task<UserDto> RegisterAsync(RegisterDto dto);
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto?> GetByIdAsync(int id);
    }
}
