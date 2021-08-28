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
        [Route("api/[controller]")]
        public IActionResult GetArticles()
        {
            return Ok(_articleData.GetArticles());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetArticle(Guid id)
        {
            var article = _articleData.GetArticle(id);
           if (article != null)
            {
                return Ok(article);
            }
            return NotFound($"The Article with Id: {id} was not found"); 
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetArticle(Article article)
        {
            _articleData.AddArticle(article);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + article.Id, article);
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteArticle(Guid id)
        {
            var article = _articleData.GetArticle(id);
            if (article != null)
            {
                _articleData.DeleteArticle(article);
                return Ok();
            }
            return NotFound($"The Article with Id: {id} was not found");
        }
    }
}
