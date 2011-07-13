using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using FluentNHibernate;

namespace FNH1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sessionFactory = CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                var testBook = new Book {Title = "Sweeping Zen"};

                try
                {
                    session.SaveOrUpdate(testBook);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("ex: {0}", ex.Message);
                }
            }
            Console.ReadKey();
        }

        private static ISessionFactory CreateSessionFactory ()
        {            
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(
                "Data Source=localhost\\SQLEXPRESS,1433;Integrated Security=True;Connect Timeout=60;Database=BookMan")).
                BuildSessionFactory();
        }
    }
}
