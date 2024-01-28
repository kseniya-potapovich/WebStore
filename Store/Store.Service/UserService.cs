using AutoMapper;
using Store.Data.Repositories;
using Store.Data.Repositories.Contract;
using Store.Dto;
using Store.Entities;
using Store.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _clientRepository;

        public readonly IMapper _mapper;

        public UserService(IUserRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateClient(UserDto client)
        {
           // var existedClient = await _clientRepository.GetById(client.Id);
            var clientToAdd = _mapper.Map<User>(client);
            return await _clientRepository.CreateClient(clientToAdd);
        }

        public async Task<UserDto> DeleteClient(int id)
        {
            var clientToRemove = await _clientRepository.DeleteClient(id);
            return _mapper.Map<UserDto>(clientToRemove);
        }

        public async Task<UserDto> GetById(int id)
        {
            var clientToFind = await _clientRepository.GetById(id);
            return _mapper.Map<UserDto>(clientToFind);
        }

        public async Task<UserDto> Login(LoginDto loginDto)
        {
            var user = await _clientRepository.GetByLoginAndPassword(loginDto.UserName, loginDto.Password);
            return _mapper.Map<UserDto>(user);

        }
    }
}
