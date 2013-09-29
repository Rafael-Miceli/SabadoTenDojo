using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;

namespace ContactManagerAPI
{
    public class SimpleWebToken: IEnumerable<Claim>
    {
        private IEnumerable<Claim> _claims;

        public SimpleWebToken(params Claim[] claims)
        {
            // TODO: Complete member initialization
            this._claims = claims;
        }

        public override string ToString()
        {
            return "foo=bar";
        }

        public IEnumerator<Claim> GetEnumerator()
        {
            return _claims.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
