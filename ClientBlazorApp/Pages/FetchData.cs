using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ClientBlazorApp.Interfaces;
using ClientBlazorApp.Models;
using ClientBlazorApp.Services;

namespace ClientBlazorApp.Pages
{
    public partial class FetchData
    {
        [Inject]
        public IAccountService AccountService { get; set; }

        public List<Client> Clients { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var getClientsResponse = await AccountService.GetClients();
            Clients = getClientsResponse.Content;
        }
    }
}
