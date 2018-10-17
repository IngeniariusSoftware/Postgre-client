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

        public DataSet GetDataSet(string querry, out bool isSuccess, out string message)
        {
            DataSet dataSet  = new DataSet();
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(querry, _connection);
                dataAdapter.Fill(dataSet);
                isSuccess = true;
                message = string.Empty;
            }
            catch
            {
                dataSet = null;
                isSuccess = true;
                message = "Ошибка при попытке получить данные";
            }

            return dataSet;
        }
    }
}
