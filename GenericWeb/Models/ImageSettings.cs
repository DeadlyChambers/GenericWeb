using System.Collections.Generic;
using System.Linq;

namespace GenericWeb.Models
{
    public class ImageSettings
    {
        /// <summary>
        /// There can be multiply logos, you can set sizes on them. With this list
        /// you should be able to select a specific one for display in a specific spot of
        /// the site.
        /// </summary>
        public IEnumerable<Image> Logos { get; set; }
        /// <summary>
        /// The carousel will be populated with images from this collection. If this is null
        /// there will be no carousel
        /// </summary>
        public IEnumerable<Image> Carousels { get; set; }
        /// <summary>
        /// This isn't in the site yet, but I would like to use this to make a seperate style
        /// of the website where a single image is the main image.
        /// </summary>
        public IEnumerable<Article> Banners { get; set; }
        /// <summary>
        /// When bundling a group of images this is how they will be used to know they are together
        /// 
        /// </summary>
        public IEnumerable<ImageGroup> Groups { get; set; }

        public Image GetImageById(int id)
        {
            Image image = null;
            if (Logos?.Count() > 0)
            {
                image = Logos.FirstOrDefault(x => x.Id == id);
            }
            if (image != null)
                return image;
            if (Carousels?.Count() > 0)
                image = Carousels.FirstOrDefault(x => x.Id == id);
            if (image != null)
                return image;           
            return image = Groups.Select(group => group.Images.Where(img => img.Id == id))?.FirstOrDefault()?.FirstOrDefault();
        }
    }
}