using EnterpriseManagement.Application.DTOs;
using EnterpriseManagement.Infrastructure.Repositories;
using EnterpriseManagement.Domain.Entities;

namespace EnterpriseManagement.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;
        public OrderService(IOrderRepository repo) => _repo = repo;

        public async Task<IEnumerable<object>> GetAllAsync()
        {
            var orders = await _repo.GetAllAsync();
            return orders.Select(o => new { o.Id, o.OrderNumber, o.Amount, o.UserId, o.CreatedAt });
        }

        public async Task<object> CreateAsync(CreateOrderDto dto)
        {
            var order = new Order { OrderNumber = dto.OrderNumber, Amount = dto.Amount, UserId = dto.UserId };
            await _repo.AddAsync(order);
            return new { order.Id, order.OrderNumber, order.Amount, order.UserId };
        }
    }
}
