using GenericWeb.Enums;
using System.Collections.Generic;
namespace GenericWeb.Models
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public Page Page { get; set; }

        public ArticleViewModel(IEnumerable<Article> articles, Page page, string title, string message)
        {
            Articles = articles;
            Page = page;
            Title = title;
            Message = message;
        }
    }
}