using EnterpriseManagement.Application.DTOs;
namespace EnterpriseManagement.Application.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<object>> GetAllAsync();
        Task<object> CreateAsync(CreateOrderDto dto);
    }
}
