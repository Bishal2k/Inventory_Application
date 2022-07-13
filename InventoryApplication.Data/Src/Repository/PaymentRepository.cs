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
    public class PaymentRepository : PaymentRepositoryInterface
    {
        readonly SessionFactoryInterface _nHibernateHelper;
        public PaymentRepository(SessionFactoryInterface nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public async Task<Payment> GetPaymentByIdAsync(long id)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<Payment>().Where(i => i.Id == id).SingleOrDefaultAsync().ConfigureAwait(false);
        }

        public async Task<List<Payment>> GetAllPaymentsAsync()
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<Payment>().ToListAsync().ConfigureAwait(false);
        }

        public async Task InsertAsync(Payment payment)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.SaveAsync(payment).ConfigureAwait(false);
        }

        public  async Task UpdateAsync(Payment payment)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.UpdateAsync(payment).ConfigureAwait(false);
        }
    }
}
