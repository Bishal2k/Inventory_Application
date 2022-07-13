using InventoryApplication.Models.Entity;
using InventoryApplication.Repository.RepositoryInterface;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementData.HibernateHelper;

namespace InventoryApplication.Repository
{
    public class ProfileRepository : ProfileRepositoryInterface
    {
        readonly SessionFactoryInterface _nHibernateHelper;
        public ProfileRepository(SessionFactoryInterface nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        public  async Task<List<Profile>> GetAllAsync()
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<Profile>().ToListAsync().ConfigureAwait(false);

        }

        public async Task<Profile> GetByIdAsync(long id)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<Profile>().Where(i => i.Id == id).SingleOrDefaultAsync().ConfigureAwait(false);
        }

        public async Task InsertAsync(Profile profile)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.SaveAsync(profile).ConfigureAwait(false);

        }

        public async Task UpdateAsync(Profile profile)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.UpdateAsync(profile).ConfigureAwait(false);
        }
    }
}
