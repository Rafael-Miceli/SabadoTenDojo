using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContactManagerAPI
{
    public class ContactController : ApiController
    {
        private readonly static List<ContactEntryModel> contacts = new List<ContactEntryModel>();

        public HttpResponseMessage Get()
        {
            return this.Request.CreateResponse(System.Net.HttpStatusCode.OK, new ContactModel() { entries = contacts.ToArray() });
        }
        public HttpResponseMessage Post(ContactEntryModel entry)
        {
            contacts.Add(entry);
            return this.Request.CreateResponse();
        }
    }
}
