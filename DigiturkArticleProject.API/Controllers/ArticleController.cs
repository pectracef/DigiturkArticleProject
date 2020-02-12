using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkArticleProject.API.Statics;
using DigiturkArticleProject.Core.Infrastructure;
using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.ConcreateServices;
using DigiturkArticleProject.Data.Service.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DigiturkArticleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService _articleService;
        private readonly ILogger _logger;

        public ArticleController(ILogger<ArticleController> logger, IRepository<Article> articleRepository)
        {
            _articleService = (ArticleService)articleRepository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Result<List<Article>>> Get()
        {
            try
            {
                List<Article> articles = _articleService.Get();
                _logger.LogInformation("Get all Articles");
                return new Result<List<Article>>(true, "", articles);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Articles getting");
                return StatusCode(500, new Result<List<Article>>(false, "Error occurred on Articles getting"));
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Result<Article>> Get(long id)
        {
            try
            {
                Article article = _articleService.GetById(id);
                _logger.LogInformation("Get one Article");
                return new Result<Article>(true, "", article);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Article getting");
                return StatusCode(500, new Result<Article>(false, "Error occurred on Article getting"));
            }
        }

        [HttpPost]
        public ActionResult<Result<Article>> Post([FromBody]Article model)
        {
            try
            {
                model.createdUserId = Current.user.id;
                _articleService.Add(model);
                _logger.LogInformation("Added one Article");
                return new Result<Article>(true, "Article added successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Article adding");
                return StatusCode(500, new Result<Article>(false, "Error occurred on Article adding"));
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<Result<Article>> Patch(long id, [FromBody]Article model)
        {
            try
            {
                model.updatedUserId = Current.user.id;
                _articleService.Update(model, id);
                _logger.LogInformation("Updated one Article");
                return new Result<Article>(true, "Article updated successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Article updating");
                return StatusCode(500, new Result<Article>(false, "Error occurred on Article updating"));
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Result<Article>> Delete(long id)
        {
            try
            {
                _articleService.Remove(id);
                _logger.LogInformation("Deleted one Article");
                return new Result<Article>(true, "Article deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Article deleting");
                return StatusCode(500, new Result<Article>(false, "Error occurred on Article deleting"));
            }
        }
    }
}