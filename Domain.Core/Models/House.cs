using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Models
{
    public class House
    {
        public int House_id { get; set; }     
        public string? Area { get; set; }
        [DisplayName("count_room")]
        public int Count_Room { get; set; }
        [Column("city_id")]
        public int City_id { get; set; }
        public string? AddressLine { get; set; }
        public string? Price { get; set; }
        public string? Contact { get; set; }
        public string? Contact_name { get; set; }
        public DateTime Created_at { get; set; }
        public string? city_name { get; set; }   
        public bool? is_sold { get; set; } = false;

    }
}
