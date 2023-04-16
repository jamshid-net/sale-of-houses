using Dapper;
using Domain.Core.Models;
using Infrastructure.Data.Connections;
using Infrastructure.Data.HashMethods;
using Npgsql;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Data.Logins
{
    public class LoginBroker
    {
        private static string? user_name { get; set; }
        private static string? password { get; set; }



        public LoginBroker(string _user_name, string _password)
        {
            user_name = _user_name;
            password = _password;

        }
       

        public Broker LoginBr()
        {

           
            try
            {
                
                return GetBroker().First(x => x.Username == user_name && x.Password == HashClass.HashPassword(password));
            }
            catch (Exception e)
            {

                throw new Exception("Password or Username incorrect");
            }




        }

        public static IEnumerable<Broker> GetBroker()
        {


            using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
            {
                conn.Open();
                return conn.Query<Broker>("Select * from broker");
            }
        }





    }







}

