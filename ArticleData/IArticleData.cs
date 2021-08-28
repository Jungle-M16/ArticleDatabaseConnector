using ArticleDatabaseConnector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDatabaseConnector.ArticleData

{
    public interface IArticleData
    {
        List<Article> GetArticles();
        Article GetArticle(Guid id);
        Article AddArticle(Article article);

        void DeleteArticle(Article article);

        Article EditArticle(Article article); 
    }
}
