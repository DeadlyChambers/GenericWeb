using System.Collections.Generic;
namespace GenericWeb.Models
{
    public class ContactSettings
    {
      
        public string Facebook { get; set; }
        public IEnumerable<Email> Emails { get; set; }

        public IEnumerable<Address> Addresses { get; set; }
    }
}