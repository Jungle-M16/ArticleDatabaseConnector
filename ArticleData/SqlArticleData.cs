using ArticleDatabaseConnector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDatabaseConnector.ArticleData
{
    public class SqlArticleData : IArticleData
    {
        private ArticleContext _ctx;
        public SqlArticleData(ArticleContext ctx)
        {
            _ctx = ctx;
        }
        public Article AddArticle(Article article)
        {
            article.Id = Guid.NewGuid();
            _ctx.Articles.Add(article);
            _ctx.SaveChanges();
            return article; 
        }

        public void DeleteArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public Article GetArticle(Guid id)
        {
            var article = _ctx.Articles.Find(id);
            return article; 
        }

        public List<Article> GetArticles()
        {
            return _ctx.Articles.ToList();
        }
    }
}
