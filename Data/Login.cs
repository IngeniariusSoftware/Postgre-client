using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Login
    {
        public string Host { get; }

        public string DataBase { get; }

        public string User { get; }

        public string Password { get; }

        public string Port { get; }

        public Login(string host, string dataBase, string user, string password = "", string port = "5432")
        {
            Host = host;
            DataBase = dataBase;
            User = user;
            Password = password;
            Port = port;
        }
    }
}
