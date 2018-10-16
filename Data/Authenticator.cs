using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public class Authenticator
    {
        public NpgsqlConnection Connection => _connection;

        private NpgsqlConnection _connection;

        public Task<bool> Connect(Login login)
        {
            string connectionRequest = string.Format(
                "Server={0};Port={1};User Id={2};Password={3};Database={4};Timeout=3;",
                login.Host,
                login.Port,
                login.User,
                login.Password,
                login.DataBase);
            return Task.Run(
                () =>
                    {
                        try
                        {
                            NpgsqlConnection connection = new NpgsqlConnection(connectionRequest);
                            connection.Open();
                            _connection = connection;
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                    });
        }
    }
}

