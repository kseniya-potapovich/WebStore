using Microsoft.AspNetCore.Mvc;
using Store.Dto;
using Store.Service;
using Store.Service.Contract;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IUserService _clientService;

        public UserController(IUserService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<UserDto>> GetById(int id)
        {
            return await _clientService.GetById(id);
        }
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> GetByLoginAndPassword(LoginDto login)
        {
            return await _clientService.Login(login);
        }

       

        [HttpPost]
        public async Task<ActionResult<int>> CreateClient([FromBody] UserDto client)
        {
            return await _clientService.CreateClient(client);
        }

        [HttpDelete]
        public async Task<ActionResult<UserDto>> DeleteClient(int id)
        {
            return await _clientService.DeleteClient(id);
        }
    }
}
