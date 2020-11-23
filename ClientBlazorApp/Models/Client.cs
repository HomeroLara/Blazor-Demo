using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBlazorApp.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public List<Demo> Demos { get; set; }
    }
}
