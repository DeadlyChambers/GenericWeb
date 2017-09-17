using System.Collections.Generic;
namespace GenericWeb.Models
{
    public class Address
    {
        /// <summary>
        /// If you want to associate a name with an address use this
        /// Example: John Smith
        /// </summary>
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public IEnumerable<Phone> Phones { get; set; }
    }
}