using GenericWeb.Enums;
namespace GenericWeb.Models
{
    public class Image
    {
        /// <summary>
        /// This will be the name of the image used in view as the src of the <img></img>
        /// Example Logo.png
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This will be the name of the image used in view as the src of the <img></img>
        /// except this will be a smaller version of the same pic try to cap this at 300px
        /// Example Logo.png
        /// </summary>
        public string NameSmall { get; set; }
        /// <summary>
        /// Description will be displayed with the image depending
        /// on how the image is being used in the view
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// If a name is being displayed this will be the displayed
        /// with the image
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// If the image is going to allow for clicking and naviagtion
        /// this will be where the link goes
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// Text that will display for a link
        /// </summary>
        public string LinkDisplayText { get; set; }
        /// <summary>
        /// Hopefully this will help with dynamic image sizes. Like you can have multiple
        /// logos, and if there is a small logo it will show up somewhere
        /// </summary>
        public ImageSize ImageSize { get; set; }
        /// <summary>
        /// The alt will be the text in the hover over
        /// </summary>
        public string Alt { get; set; }
        /// <summary>
        /// Used by Article to know if they are going to display an image
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Any specific classes you want applied to the IMG tag.
        /// </summary>
        public string Class { get; set;}
     
    }
}