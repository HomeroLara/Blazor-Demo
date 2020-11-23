using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientBlazorApp.Models;

namespace ClientBlazorApp.Interfaces
{
    public interface IAccountService
    {
        Task<HttpProxyResponse<List<Client>>> GetClients();
    }
}
