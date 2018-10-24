using System.Threading.Tasks;

namespace Data
{
    using Npgsql;

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
                        _connection?.Close();
                        try
                        {
                            _connection = new NpgsqlConnection(connectionRequest);
                            _connection.Open();
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

