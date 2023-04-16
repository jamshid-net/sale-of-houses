using Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Models
{
    public class ClientUser
    {
        public int Client_id { get; set; }
        public string? User_name { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        

    }
}
