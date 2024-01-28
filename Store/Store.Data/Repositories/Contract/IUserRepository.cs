using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories.Contract
{
    public interface IUserRepository
    {
        public Task<int> CreateClient(User client);
        public Task<User> DeleteClient(int id);
        public Task<User> GetById(int id);

        public Task<User> GetByLoginAndPassword(string login, string password);
    }
}
