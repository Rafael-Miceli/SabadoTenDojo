using System;
using Xunit;
using System.Net.Http;

namespace ContactManager.AcceptanceTests
{    
    public class HomeJsonTest
    {
        [Fact]
        public void ShouldReturnCorrectStatusCode()
        {
            using (var client = HttpClientFactory.Create())
            {                
                var response = client.GetAsync("").Result;
                Assert.True(response.IsSuccessStatusCode, "Actual code: "+response.StatusCode);
            }
        }

        [Fact]
        public void PostShouldReturnCorrectStatusCode()
        {
            using (var client = HttpClientFactory.Create())
            {
                var json = new
                {
                    Name = "Ricardo",
                    Number = "9999999",
                    Birthday = DateTimeOffset.Now
                };
                var response = client.PostAsJsonAsync("",json).Result;
                Assert.True(response.IsSuccessStatusCode, "Actual code: " + response.StatusCode);
            }
        }

        [Fact]
        public void GetPostShouldReturnPostedEntry()
        {
            using (var client = HttpClientFactory.Create())
            {
                var json = new
                {
                    Name = "Rafael",
                    Number = "9888888",
                    Birthday = DateTimeOffset.Now
                };

                var expectedValue = json.ToJObject();                

                client.PostAsJsonAsync("", json).Wait();

                var response = client.GetAsync("").Result;

                var actual = response.Content.ReadAsJsonAsync().Result;

                Assert.Contains(expectedValue, actual.entries);
            }
        }
    }
}
