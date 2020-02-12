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
using Microsoft.Extensions.Caching.Memory;
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
        private readonly IMemoryCache _memoryCache;

        public ArticleController(ILogger<ArticleController> logger, IMemoryCache memoryCache, IRepository<Article> articleRepository)
        {
            _articleService = (ArticleService)articleRepository;
            _logger = logger;
            _memoryCache = memoryCache;
        }

        [HttpGet]
        public ActionResult<Result<List<Article>>> Get()
        {
            try
            {
                List<Article> articles = new List<Article>();
                const string key = "articleAll";
                if (_memoryCache.TryGetValue(key, out articles))
                    return new Result<List<Article>>(true, "", articles);

                articles = _articleService.Get();
                _memoryCache.Set(key, articles, new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(1),
                    Priority = CacheItemPriority.Normal
                });
                _logger.LogInformation("Get all Articles");
                return new Result<List<Article>>(true, "", articles);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Articles getting");
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Result<Article>> Get(long id)
        {
            try
            {
                Article article = new Article();
                const string key = "articleSingle";
                if (_memoryCache.TryGetValue(key, out article))
                    return new Result<Article>(true, "", article);

                article = _articleService.GetById(id);
                _memoryCache.Set(key, article, new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(1),
                    Priority = CacheItemPriority.Normal
                });
                _logger.LogInformation("Get one Article");
                return new Result<Article>(true, "", article);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Article getting");
                throw ex;
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
                throw ex;
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<Result<Article>> Patch(long id, [FromBody]Article model)
        {
            try
            {
                Article data = _articleService.GetById(id);
                if (data.createdUserId == Current.user.id || Current.user.roleId == 1)
                {
                    data.updatedUserId = Current.user.id;
                    data.title = model.title;
                    data.subTitle = model.subTitle;
                    data.content = model.content;
                    _articleService.Update(data, id);
                    _logger.LogInformation("Updated one Article");
                    return new Result<Article>(true, "Article updated successfully");
                }
                else
                {
                    return StatusCode(403, new Result<Article>(false, "You are not authorized."));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Article updating");
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Result<Article>> Delete(long id)
        {
            try
            {
                Article data = _articleService.GetById(id);
                if (data.createdUserId == Current.user.id || Current.user.roleId == 1)
                {
                    _articleService.Remove(id);
                    _logger.LogInformation("Deleted one Article");
                    return new Result<Article>(true, "Article deleted successfully");
                }
                else
                {
                    return StatusCode(403, new Result<Article>(false, "You are not authorized."));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Article deleting");
                throw ex;
            }
        }

        [HttpGet("search/{query}")]
        public ActionResult<Result<List<Article>>> Search(string query)
        {
            try
            {
                return _articleService.Search(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}