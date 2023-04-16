using Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IClientUserRepository : IDisposable
    {
        IEnumerable<ClientUser> GetClientUsers();
        void CreateUser(ClientUser user);
        void UpdateUser(ClientUser user);
        void DeleteUser(int UserId);

    }
}
