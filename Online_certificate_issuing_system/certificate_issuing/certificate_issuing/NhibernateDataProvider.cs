using certificate_issuing.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace certificate_issuing
{
    public class NhibernateDataProvider
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                                .Database(MsSqlConfiguration.MsSql2012
                                .ConnectionString(c => c
                                .Server("WKS107\\WIKI")
                                .Database("certificate_issuing")
                                .Username("wiki")
                                .Password("wiki")))
                                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<certificateMap>())
                                .ExposeConfiguration(cfg => new SchemaUpdate(cfg)
                                                                  .Execute(true, true))
                                .BuildSessionFactory();
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}