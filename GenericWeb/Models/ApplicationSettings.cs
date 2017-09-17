using System.Collections.Generic;
namespace GenericWeb.Models
{
    public class ApplicationSettings
    {
        public string Phone { get; set; }
        public string CompanyName { get; set; }
        public ContactSettings Contacts { get; set; }
        public ImageSettings Images { get; set; }
        public IEnumerable<Article> Articles { get; set; }

        public IEnumerable<Article> Banners { get; set; }
    }
}