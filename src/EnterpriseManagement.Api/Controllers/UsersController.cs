using Microsoft.AspNetCore.Mvc;
using EnterpriseManagement.Application.DTOs;
using EnterpriseManagement.Application.Services;
using Microsoft.AspNetCore.Authorization;

namespace EnterpriseManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService) => _userService = userService;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _userService.GetAllAsync());

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _userService.GetByIdAsync(id));
    }
}
