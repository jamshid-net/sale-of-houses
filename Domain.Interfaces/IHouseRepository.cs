using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core;
using Domain.Core.Models;

namespace Domain.Interfaces
{
    public interface IHouseRepository 
    {
        IEnumerable<House> GetHouses();
        House GetHouseById(int id);
        Task CreateHouse(House house);
        Task UpdateHouse(House house);
        Task DeleteHouse(int HouseId);
      

    }
}
