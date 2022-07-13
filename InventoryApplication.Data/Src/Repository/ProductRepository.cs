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
    public class ProductRepository : ProductRepositoryInterface
    {
        readonly SessionFactoryInterface _nHibernateHelper;
        public ProductRepository(SessionFactoryInterface nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            return await session.Query<Product>().ToListAsync().ConfigureAwait(false);
        }

        public async Task<Product> GetByIdAsync(long id)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            //return await session.Query<Product>().Where(i => i.Id == id).SingleOrDefaultAsync().ConfigureAwait(false);
            return await  session.GetAsync<Product>(id);
        }
       

        public async Task InsertAsync(Product product)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.SaveAsync(product).ConfigureAwait(false);
          
        }

        public async Task UpdateAsync(Product product)
        {
            ISession session = _nHibernateHelper.GetCurrentSession();
            await session.UpdateAsync(product).ConfigureAwait(false);         
        }
    }
}
