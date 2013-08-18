using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.AcceptanceTests
{
    public static class ContentReader
    {
        public static dynamic ToJObject(this object value)
        {
            return JsonConvert.DeserializeObject(JsonConvert.SerializeObject(value));
        }

        public static Task<dynamic> ReadAsJsonAsync(this HttpContent content)
        {
            if (content == null)
                throw new ArgumentException("Bla bla");

            return content.ReadAsStringAsync().ContinueWith(t => JsonConvert.DeserializeObject(t.Result));
        }
    }
}
