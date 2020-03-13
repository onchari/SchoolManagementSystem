using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace School_Web_Application.Helpers
{
    public class SchoolHelper
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:57577");
            return Client;
        }
    }
}
