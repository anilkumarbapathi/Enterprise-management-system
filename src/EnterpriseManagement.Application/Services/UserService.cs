using EnterpriseManagement.Application.DTOs;
using EnterpriseManagement.Infrastructure.Repositories;
using EnterpriseManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseManagement.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo) => _repo = repo;

        public async Task<UserDto> RegisterAsync(RegisterDto dto)
        {
            var existing = await _repo.GetByEmailAsync(dto.Email);
            if (existing != null) throw new ApplicationException("Email already used");
            var user = new User { Name = dto.Name, Email = dto.Email, PasswordHash = dto.Password };
            await _repo.AddAsync(user);
            return new UserDto{ Id = user.Id, Name = user.Name, Email = user.Email };
        }

        public async Task<UserDto?> AuthenticateAsync(LoginDto dto)
        {
            var user = await _repo.GetByEmailAsync(dto.Email);
            if (user == null || user.PasswordHash != dto.Password) return null;
            return new UserDto{ Id=user.Id, Name=user.Name, Email=user.Email };
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _repo.GetAllAsync();
            return users.Select(u => new UserDto{ Id=u.Id, Name=u.Name, Email=u.Email });
        }

        public async Task<UserDto?> GetByIdAsync(int id)
        {
            var u = await _repo.GetByIdAsync(id);
            if (u == null) return null;
            return new UserDto{ Id=u.Id, Name=u.Name, Email=u.Email };
        }
    }
}
