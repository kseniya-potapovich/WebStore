using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public class BaseRepository
    {
        public readonly StoreDbContext _context;

        public BaseRepository(StoreDbContext storeDbContext)
        {
            _context = storeDbContext;
        }
    }
}
