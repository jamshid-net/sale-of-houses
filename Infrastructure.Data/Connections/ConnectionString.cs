using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Infrastructure.Data.Connections
{
    public class ConnectionString
    {
        public string? MyConnection { get; set; }
    }
    
    public class Root
    {
        public  ConnectionString? ConnectionStrings { get; set; }
    }

    public class  Connection
    {
       
        
        private static readonly string _path = @"D:\ForGitHub\House_sale\Infrastructure.Data\Connections\connection.json";

        public static string GetString()
        {
           
            Root? root = JsonConvert.DeserializeObject<Root?>(File.ReadAllText(_path));

            return root.ConnectionStrings?.MyConnection;

        }


    }


}
