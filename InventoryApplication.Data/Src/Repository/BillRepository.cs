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
    public class BillRepository : BillRepositoryInterface
    {
        readonly SessionFactoryInterface _nHibernateHelper;
        public BillRepository(SessionFactoryInterface nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        public async Task<Bill> GetById(long id)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.GetAsync<Bill>(id);
        }

        public async Task InsertAsync(Bill bill)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.SaveAsync(bill).ConfigureAwait(false);
        }

        public async Task UpdateAsync(Bill bill)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.UpdateAsync(bill).ConfigureAwait(false);
        }
        public async Task<Bill> GetLatestBillAsync()
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            var maxTimeStamp = session.Query<Bill>().Max(x => x.TimeStamp);
            return await session.Query<Bill>().Where(x => x.TimeStamp == maxTimeStamp).SingleOrDefaultAsync().ConfigureAwait(false);
        }

        public async Task<List<Bill>> GetAllAsync()
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<Bill>().ToListAsync().ConfigureAwait(false);
        }
    }
}
