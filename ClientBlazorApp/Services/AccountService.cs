using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using ClientBlazorApp.Models;
using ClientBlazorApp.Interfaces;

namespace ClientBlazorApp.Services
{
    public class AccountService: IAccountService
    {
        private readonly HttpClient _httpClient;
        public AccountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpProxyResponse<List<Client>>> GetClients()
        {
            try
            {
                var clients = await JsonSerializer.DeserializeAsync<HttpProxyResponse<List<Client>>>
                    (await _httpClient.GetStreamAsync($"api/account"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                var response = new HttpProxyResponse<List<Client>>()
                {
                    Content = clients.Content,
                    IsSuccessStatusCode = true,
                    StatusCode = System.Net.HttpStatusCode.OK,
                };

                return response;
            }
            catch(Exception ex)
            {
                var err = ex.Message;
            }

            return null;
        }
    }
}
