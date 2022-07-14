using NHibernate;
using NHibernate.Cfg;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISession = NHibernate.ISession;
using Microsoft.AspNetCore.Http;

namespace UserManagementData.HibernateHelper
{

    public class NHibernateHelper : SessionFactoryInterface
    {
        private const string CurrentSessionKey = "nhibernate.current_session";
        private readonly ISessionFactory _sessionFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public NHibernateHelper(IHttpContextAccessor httpContextAccessor)
        {
            _sessionFactory = new Configuration().Configure("hibernate.cfg.xml").AddAssembly("InventoryApplication.Data").BuildSessionFactory();
            _httpContextAccessor = httpContextAccessor;
        }
        public ISession GetCurrentSession()
        {
            var context = _httpContextAccessor.HttpContext;
            var currentSession = context.Items[CurrentSessionKey] as ISession;
            if (currentSession == null)
            {
                currentSession = _sessionFactory.OpenSession();
                context.Items[CurrentSessionKey] = currentSession;
            }

            return currentSession;
        }
        public  void CloseSession()
        {
            var context = _httpContextAccessor.HttpContext;
            var currentSession = context.Items[CurrentSessionKey] as ISession;

            if (currentSession == null)
            {
                return;
            }

            currentSession.Close();
            context.Items.Remove(CurrentSessionKey);
        }

        public  void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }
    }
}
