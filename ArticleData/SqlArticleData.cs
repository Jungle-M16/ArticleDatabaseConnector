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
        public List<Article> GetArticlesByAuthor(int id)
        {
            var articles = _ctx.Articles
                .Where(x => x.AuthorId == id)
                .OrderByDescending(y => y.Popularity)
                .ToList();
            return articles;
        }
        public List<Author> GetAuthors()
        {
            var authors = _ctx.Authors.ToList();
            return authors;
        }
        public List<Article> GetArticlesBySubjectType(string subject)
        {
            var articles = _ctx.Articles
                .Where(x => x.Category == subject)
                .OrderByDescending(y => y.Popularity)
                .ToList();
            return articles;
        }
        public Article GetLatestArticleBySubjectType(string subject)
        {
            var article = _ctx.Articles
                .Where(x => x.Category == subject)
                .OrderByDescending(y => y.DatePublished)
                .FirstOrDefault();
            return article;
        }

    public Article GetArticle(Guid id)
        {
            var article = _ctx.Articles.Find(id);
            return article; 
        }

        public List<Article> GetArticles()
        {
            return _ctx.Articles
                .OrderByDescending(y => y.Popularity)
                .ToList();
        }
    }
}
