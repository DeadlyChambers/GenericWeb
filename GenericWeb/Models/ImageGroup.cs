using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericWeb.Models
{
    /// <summary>
    /// This will allow for images to be displayed in groups
    /// </summary>
    public class ImageGroup
    {
        /// <summary>
        /// The name of a group to be used more for organizational purposes and 
        /// not displayed to the user
        /// </summary>
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public IEnumerable<Image> Images { get; set; }
        /// <summary>
        /// Used by articles to know if they are going to use an image group
        /// </summary>
        public int Id { get; set; }
    }
}
