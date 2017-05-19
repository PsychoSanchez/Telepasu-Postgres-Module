using System.Collections.Generic;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace DataBaseTest
{
    static public class DataBaseMethods
    {
        static public List<ContactData> GetContactsBook(string user)
        {
            List<ContactData> temp = new List<ContactData>();

            var wtf = (from p in DataBaseModule.sf.OpenSession().Query<CallHistory>()
                       where p.Number == "123"
                       select p).FirstOrDefault();

            return temp;
        }
    }
}
