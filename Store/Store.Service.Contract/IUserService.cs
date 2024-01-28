using Store.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Contract
{
    public interface IUserService
    {
        public Task<int> CreateClient(UserDto client);
        public Task<UserDto> DeleteClient(int id);
        public Task<UserDto> GetById(int id);
        public Task<UserDto> Login(LoginDto loginDto);
    }
}
