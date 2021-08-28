using ArticleDatabaseConnector.ArticleData;
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

    }
}
