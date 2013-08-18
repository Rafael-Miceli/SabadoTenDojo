using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactManagerAPI
{
    public class ContactEntryModel
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTimeOffset Birthday { get; set; }
    }
}
