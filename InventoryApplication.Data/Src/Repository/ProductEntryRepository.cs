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
    public class ProductEntryRepository : ProductEntryRepositoryInterface
    {
        readonly SessionFactoryInterface _nHibernateHelper;
        public ProductEntryRepository(SessionFactoryInterface nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public async Task<List<ProductEntryData>> GetAllAsync()
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<ProductEntryData>().ToListAsync().ConfigureAwait(false);           
        }

        public async Task<ProductEntryData> GetByIdAsync(long id)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.GetAsync<ProductEntryData>(id);
            
        }

        public  async Task InsertAsync(ProductEntryData productEntry)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.SaveAsync(productEntry).ConfigureAwait(false);
        }

        public async Task UpdateAsync(ProductEntryData productEntry)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.UpdateAsync(productEntry).ConfigureAwait(false);
        }

       
    }
}
