using EnterpriseManagement.Domain.Entities;
namespace EnterpriseManagement.Infrastructure.Repositories
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
        Task<IEnumerable<Order>> GetAllAsync();
    }
}
