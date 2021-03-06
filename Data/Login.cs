﻿namespace Data
{
    public class Login
    {
        public string Host { get; }

        public string DataBase { get; }

        public string User { get; }

        public string Password { get; }

        public string Port { get; }

        public Login()
        {
            Host = string.Empty;
            DataBase = string.Empty;
            User = string.Empty;
            Password = string.Empty;
            Port = string.Empty;
        }

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
