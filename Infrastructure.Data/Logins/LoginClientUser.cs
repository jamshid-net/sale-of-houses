using Dapper;
using Domain.Core.Models;
using Infrastructure.Data.Connections;
using Infrastructure.Data.HashMethods;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Logins
{
    public class LoginClientUser
    {
        private static string? user_name { get; set; }
        private static string? password { get; set; }
        public LoginClientUser(string _user_name, string _password)
        {
            user_name = _user_name;
            password = _password;

        }

        public ClientUser LoginClient()
        {


            try
            {

                return GetClients().First(x => x.User_name == user_name && x.Password == HashClass.HashPassword(password));
            }
            catch (Exception e)
            {

                throw new Exception("Password or Username incorrect");
            }




        }

        public static IEnumerable<ClientUser> GetClients()
        {


            using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
            {
                conn.Open();
                return conn.Query<ClientUser>("Select * from clientuser");
            }
        }
    }
}
