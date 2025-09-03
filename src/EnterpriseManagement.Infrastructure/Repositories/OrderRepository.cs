using EnterpriseManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseManagement.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _db;
        public OrderRepository(AppDbContext db) => _db = db;

        public async Task AddAsync(Order order)
        {
            _db.Orders.Add(order);
            await _db.SaveChangesAsync();
        }

        public Task<IEnumerable<Order>> GetAllAsync() =>
            Task.FromResult<IEnumerable<Order>>(_db.Orders.AsNoTracking().ToList());
    }
}
