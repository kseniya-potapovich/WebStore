using Microsoft.EntityFrameworkCore;
using Store.Data.Repositories.Contract;
using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Store.Data.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(StoreDbContext storeDbContext) : base(storeDbContext)
        {
        }
        public async Task<int> CreateClient(User client)
        {
            await _context.Users.AddAsync(client);
            await _context.SaveChangesAsync();
            return client.Id;
        }

        public async Task<User> DeleteClient(int id)
        {
            var clientToDelete = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (clientToDelete != null)
            {
                _context.Users.Remove(clientToDelete);
                _context.SaveChanges();
                return clientToDelete;
            }
            return null;
        }

        public async Task<User> GetById(int id)
        {
            var client = await _context.Users.FindAsync(id);
          
            return client;
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByLoginAndPassword(string login, string password)
        {

           var user = await _context.Users.FirstOrDefaultAsync(c => c.Login == login && c.Password == password);
            //обработка когда не совпали логин и пароль
           /* if(user == null)
            {
                throw new HttpResponseException(HttpStatusCode.Unauthorized);
            }*/
            return user;
        }
    }
}
