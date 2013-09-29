using System.Collections.Generic;
using System.Security.Claims;
using Xunit;
using System.Linq;
using Xunit.Extensions;

namespace ContactManagerAPI.UnitTests
{
    
    public class SimpleWebTokenTests
    {
        [Fact]
        public void SutIsIteratorOfClaims()
        {
            var sut = new SimpleWebToken();
            Assert.IsAssignableFrom<IEnumerable<Claim>>(sut);
        }

        [Fact]
        public void YieldEnumeratorOfClaims()
        {
            var expected = new[]
                {
                    new Claim("foo", "bar"),
                    new Claim("queue", "qux"),
                    new Claim("Rafael", "Ricardo")
                };

            var sut = new SimpleWebToken(expected);

            Assert.True(expected.SequenceEqual(sut));
            Assert.True(expected.Cast<object>().SequenceEqual(sut.OfType<object>()));

        }

        [Theory]
        [InlineData("", "")]
        [InlineData(new[] {"foo|bar"}, "foo=bar")]
        public void ToStringShouldBeRight(string[] action, string expected)
        {
            //var expected = new[]
            //    {
            //        new Claim("foo", "bar")
            //    };
            var claims = action.Select(s => s.Split('|')).Select(a => new Claim(a[0], a[1])).ToArray();            

            var sut = new SimpleWebToken(claims);

            Assert.Equal(expected, sut.ToString());
        }
    }
}
