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

namespace Infrastructure.Data.Registrations
{
    public class RegClientUser
    {
        private string _username;
        private ClientUser _user;
        public RegClientUser(ClientUser user)
        {
            this._username = user.User_name;
            this._user = user;

        }



        public bool RegisterUser()
        {
            if (!CheckForNotRegistered())
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
                {
                    conn.Open();
                    conn.Query(@$"insert into clientuser(password, fullname, age, phone, user_name, email)
                                values('{HashClass.HashPassword(_user.Password)}',
                                       '{_user.FullName}','{_user.Age}','{_user.Phone}','{_user.User_name.ToLower()}','{_user.Email.ToLower()}')");
                }
                return true;
            }
            else return false;

        } 

        public bool CheckForNotRegistered()
        {
            bool result = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(Connection.GetString()))
            {
                conn.Open();
              result =  conn.Query(@$"Select user_name 
                            from clientuser 
                            where user_name = '{_username.ToLower()}'").Any();
            }
            return result;
        }



    }
}
