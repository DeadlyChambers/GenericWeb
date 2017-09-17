using GenericWeb.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericWeb.Models
{
    public class Article
    {
        /// <summary>
        /// Page to be displayed on
        /// </summary>
        public Page Page { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime Created { get; set; }
        public Image Image { get; set; }
    }
}
