using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Repository.RepositoryInterface
{
    public interface UserRepositoryInterface
    {
        public Task<User> GetByUserNameAsync(string userName);
        public Task InsertAsync(User user);
        public Task UpdateAsync(User user);
    }
}
