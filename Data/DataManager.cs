using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    using System.Data;
    using System.Windows.Forms;

    using Npgsql;

    public class DataManager
    {
        public string CurrentScheme = string.Empty;

        private NpgsqlConnection _connection;

        public DataManager(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public DataTable GetTable(string objectType, string objectName)
        {
            DataTableCollection dataTables = MakeRequest(objectType, objectName).Tables;
            if (dataTables.Count > 0)
            {
            return dataTables[0];
            }
            else
            {
                return null;
            }
        }

        public List<string> GetObjects(string objectType)
        {
            DataSet dataSet = MakeRequest(objectType);
            return dataSet.Tables[0].AsEnumerable().Select(dataRow => dataRow.Field<string>(string.Format("{0}name", objectType))).ToList();
        }

        private DataSet MakeRequest(string objectType, string objectName = null)
        {
            string request = "";
            switch (objectType)
            {
                case "schemes":
                    {
                        request = (@"select nspname as schemesname
                                       from pg_catalog.pg_nameSpace
                                      where oid not in (11, 99, 11480, 11215, 11216)");
                        break;
                    }

                case "tables":
                    {
                        request = string.Format(@"select pc.relname as tablesname
                                                    from pg_catalog.pg_class pc,
                                                         pg_catalog.pg_namespace pn
                                                   where pc.relnamespace = pn.oid
                                                     and pc.relkind = 'r'
                                                     and pn.nspname = '{0}'", CurrentScheme);
                        break;
                    }

                case "alltables":
                    {
                        request = (@"select relname as alltablesname
                                       from pg_catalog.pg_class
                                      where relkind = 'r'");
                        break;
                    }

                case "views":
                    {
                        request = string.Format(@"select viewname as viewsname
                                                    from pg_catalog.pg_views
                                                   where schemaname = '{0}'", CurrentScheme);
                        break;
                    }

                case "procedures":
                    {
                        request = string.Format(@"select pp.proname as proceduresname
                                                    from pg_catalog.pg_proc pp,
                                                         pg_catalog.pg_namespace pn
                                                   where pp.pronamespace = pn.oid
                                                     and pn.nspname = '{0}'", CurrentScheme);
                        break;
                    }

                case "table":
                    {
                        request = string.Format(@"select *
                                                    from {0}.{1}", CurrentScheme, objectName);
                        break;
                    }

                case "view":
                    {
                        request = string.Format(@"select *
                                                    from {0}.{1}", CurrentScheme, objectName);
                        break;
                    }

                case "procedure":
                    {
                        request = string.Format(@"select pp.prosrc
                                                    from pg_proc pp,
                                                         pg_catalog.pg_namespace pn
                                                   where pn.nspname = '{0}'
                                                     and pp.pronamespace = pn.oid
                                                     and pp.proname = '{1}'", CurrentScheme, objectName);
                        break;
                    }
            }

            return GetDataSet(request);
        }


        public DataSet GetDataSet(string request)
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
