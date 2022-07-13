using InventoryApplication.Models.Entity;
using InventoryApplication.Repository.RepositoryInterface;
using System;
using NHibernate;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementData.HibernateHelper;
using NHibernate.Linq;

namespace InventoryApplication.Repository
{
    public class UserRepository : UserRepositoryInterface
    {
        readonly SessionFactoryInterface _nHibernateHelper;
        public UserRepository(SessionFactoryInterface nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        public async Task<User> GetByUserNameAsync(string userName)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<User>().Where(x => x.Username == userName).SingleOrDefaultAsync().ConfigureAwait(false);
        }

        public Task InsertAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
