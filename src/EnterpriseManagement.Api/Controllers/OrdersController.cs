using Microsoft.AspNetCore.Mvc;
using EnterpriseManagement.Application.Services;
using EnterpriseManagement.Application.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace EnterpriseManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService) => _orderService = orderService;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _orderService.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderDto dto) => Ok(await _orderService.CreateAsync(dto));
    }
}
