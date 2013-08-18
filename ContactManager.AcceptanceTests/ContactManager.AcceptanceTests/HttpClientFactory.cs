using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.SelfHost;

namespace ContactManager.AcceptanceTests
{
    public static class HttpClientFactory
    {
        public static HttpClient Create()
        {
            Uri baseUri = new Uri("http://localhost:8080/");
            var config = new HttpSelfHostConfiguration(baseUri);

            new Bootstrapper().Configure(config);
            var server = new HttpSelfHostServer(config);

            var client = new HttpClient(server);

            client.BaseAddress = baseUri;

            return client;

        }
    }
}
