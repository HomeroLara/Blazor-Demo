using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBlazorApp.Models
{
    public class HttpProxyResponse<T>
    {
        public System.Net.HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccessStatusCode { get; set; }
        public T Content { get; set; }
    }
}
