using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    using System.Data;
    using Npgsql;

    public class DataManager
    {
        private NpgsqlConnection _connection;

        public DataManager(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public DataSet MakeRequest(ObjectTypeEnum.ObjectType objectType, string schemeName, string objectName = null)
        {
            string request = "";
            switch (objectType)
            {
                case ObjectTypeEnum.ObjectType.Schemes:
                    {
                        request = (@"select nspname as schemename
                                       from pg_catalog.pg_namespace
                                      where oid not in (11, 99, 11480, 11215, 11216)");
                        break;
                    }

                case ObjectTypeEnum.ObjectType.Tables:
                    {
                        request = string.Format(@"select pc.relname as tablename
                                                    from pg_catalog.pg_class pc,
                                                         pg_catalog.pg_namespace pn
                                                   where pc.relnamespace = pn.oid
                                                     and pn.nspname = '{0}'", schemeName);
                        break;
                    }

                case ObjectTypeEnum.ObjectType.Views:
                    {
                        request = string.Format(@"select viewname as viewname
                                                    from pg_catalog.pg_views
                                                   where schemaname = '{0}'", schemeName);
                        break;
                    }

                case ObjectTypeEnum.ObjectType.Procedures:
                    {
                        request = string.Format(@"select pp.proname as procname
                                                    from pg_catalog.pg_proc pp,
                                                         pg_catalog.pg_namespace pn
                                                   where pp.pronamespace = pn.oid
                                                     and pn.nspname = '{0}'", schemeName);
                        break;
                    }

                case ObjectTypeEnum.ObjectType.Table:
                    {
                        request = string.Format(@"select *
                                                    from {0}.{1}", schemeName, objectName);
                        break;
                    }

                case ObjectTypeEnum.ObjectType.View:
                    {
                        request = string.Format(@"select *
                                                    from {0}.{1}", schemeName, objectName);
                        break;
                    }

                case ObjectTypeEnum.ObjectType.Procedure:
                    {
                        request = string.Format(@"select pp.prosrc
                                                    from pg_proc pp,
                                                         pg_catalog.pg_namespace pn
                                                   where pn.nspname = '{0}'
                                                     and pp.pronamespace = pn.oid
                                                     and pp.proname = '{1}'", schemeName, objectName);
                        break;
                    }
            }

            return GetDataSet(request);
        }


        private DataSet GetDataSet(string request)
        {
            DataSet dataSet  = new DataSet();
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(request, _connection);
                dataAdapter.Fill(dataSet);
            }
            catch
            {
                dataSet = null;
            }

            return dataSet;
        }
    }
}
