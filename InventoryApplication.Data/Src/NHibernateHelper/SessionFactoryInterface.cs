using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagementData.HibernateHelper
{
    public interface SessionFactoryInterface
    {
        public ISession GetCurrentSession();
        public void CloseSession();
        public void CloseSessionFactory();
    }
}
