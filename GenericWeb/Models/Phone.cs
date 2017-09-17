namespace GenericWeb.Models
{
    public class Phone
    {
        public string Name { get; set; }
        public string Number { get; set; }
        /// <summary>
        /// Will be displayed if it exists with Ext:
        /// </summary>
        public string Ext { get; set; }
    }
}