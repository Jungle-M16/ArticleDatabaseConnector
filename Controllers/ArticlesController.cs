using ArticleDatabaseConnector.ArticleData;
using ArticleDatabaseConnector.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDatabaseConnector.Controllers
{
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleData _articleData; 
        public ArticlesController(IArticleData articleData)
        {
            _articleData = articleData;
        }
        [HttpGet]
        [Route("api/[controller]/GetAuthors")]
        public IActionResult GetAuthors()
        {
            return Ok(_articleData.GetAuthors());
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetArticles()
        {
            return Ok(_articleData.GetArticles());
        }
        [HttpGet]
        [Route("api/[controller]/GetArticle/{id}")]
        public IActionResult GetArticle(Guid id)
        {
            var article = _articleData.GetArticle(id);
           if (article != null)
            {
                return Ok(article);
            }
            return NotFound($"The Article with Id: {id} was not found"); 
        }
        [HttpGet]
        [Route("api/[controller]/GetArticlesByAuthor/{id}")]
        public IActionResult GetArticlesByAuthorId(int id)
        {
            var articles = _articleData.GetArticlesByAuthor(id);
    
            if (articles != null)
            {
                return Ok(articles);
            }
            return NotFound($"The Author with Id: {id} was not found");
        }
        [HttpGet]
        [Route("api/[controller]/GetArticlesBySubjectType/{subject}")]
        public IActionResult GetArticlesBySubjctType(string subject)
        {
            var articles = _articleData.GetArticlesBySubjectType(subject);

            if (articles != null)
            {
                return Ok(articles);
            }
            return NotFound($"The Author with subject: {subject} was not found");
        }
        //[HttpPost]
        //[Route("api/[controller]")]
        //public IActionResult GetArticle(Article article)
        //{
        //    _articleData.AddArticle(article);

        //    return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + article.Id, article);
        //}
        // Unneccessary

        //[HttpDelete]
        //[Route("api/[controller]/{id}")]
        //public IActionResult DeleteArticle(Guid id)
        //{
        //    var article = _articleData.GetArticle(id);
        //    if (article != null)
        //    {
        //        _articleData.DeleteArticle(article);
        //        return Ok();
        //    }
        //    return NotFound($"The Article with Id: {id} was not found");
        //}
    }
}
