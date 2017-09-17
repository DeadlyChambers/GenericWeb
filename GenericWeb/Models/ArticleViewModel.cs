using GenericWeb.Enums;
using System.Collections.Generic;
namespace GenericWeb.Models
{
    public class ArticleViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public Page Page { get; set; }
        public Article Article { get; set; }

        public ArticleViewModel(IEnumerable<Article> articles, Page page, Article article)
        {
            Articles = articles;
            Page = page;          
            Article = article;
        }
    }
}