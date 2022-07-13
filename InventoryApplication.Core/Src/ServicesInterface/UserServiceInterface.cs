using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Services.ServicesInterface
{
    public interface UserServiceInterface
    {
        public Task<User> GetByUserName(string userName);
    }
}
