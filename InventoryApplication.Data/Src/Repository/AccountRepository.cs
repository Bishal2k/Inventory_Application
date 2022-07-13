using InventoryApplication.Models.Entity;
using InventoryApplication.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementData.HibernateHelper;
using NHibernate;
using NHibernate.Linq;

namespace InventoryApplication.Repository
{
    public class AccountRepository : AccountRepositoryInterface
    {
        readonly SessionFactoryInterface _nHibernateHelper;
        public AccountRepository(SessionFactoryInterface nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        public async Task<List<Account>> GetAllAsync()
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<Account>().ToListAsync().ConfigureAwait(false);
        }

        public async Task<Account> GetByIdAsync(long id)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.GetAsync<Account>(id);
        }

        public async Task InsertAsync(Account account)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.SaveAsync(account).ConfigureAwait(false);
        }

        public async Task UpdateAsync(Account account)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.UpdateAsync(account).ConfigureAwait(false);
        }
        public async Task<Account> GetByProfileIdAsync(long id)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<Account>().Where(a => a.Profile.Id == id).FirstOrDefaultAsync();
        }
    }
}
