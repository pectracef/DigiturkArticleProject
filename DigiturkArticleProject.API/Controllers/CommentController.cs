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

namespace DigiturkCommentProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly CommentService _commentService;
        private readonly ILogger _logger;

        public CommentController(ILogger<CommentController> logger, IRepository<Comment> commentRepository)
        {
            _commentService = (CommentService)commentRepository;
            _logger = logger;
        }

        [HttpGet]
        [ResponseCache(Duration = 3600)]
        public ActionResult<Result<List<Comment>>> Get()
        {
            try
            {
                List<Comment> comments = _commentService.Get();
                _logger.LogInformation("Get all Comments");
                return new Result<List<Comment>>(true, "", comments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Comments getting");
                throw ex;
            }
        }

        [HttpGet("{id}")]
        [ResponseCache(Duration = 3600)]
        public ActionResult<Result<Comment>> Get(long id)
        {
            try
            {
                Comment comment = _commentService.GetById(id);
                _logger.LogInformation("Get one Comment");
                return new Result<Comment>(true, "", comment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Comment getting");
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult<Result<Comment>> Post([FromBody]Comment model)
        {
            try
            {
                model.createdUserId = Current.user.id;
                _commentService.Add(model);
                _logger.LogInformation("Added one Comment");
                return new Result<Comment>(true, "Comment added successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Comment adding");
                throw ex;
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<Result<Comment>> Patch(long id, [FromBody]Comment model)
        {
            try
            {
                Comment data = _commentService.GetById(id);
                if (data.createdUserId == Current.user.id || Current.user.roleId == 1)
                {
                    data.content = model.content;
                    _commentService.Update(data, id);
                    _logger.LogInformation("Updated one Comment");
                    return new Result<Comment>(true, "Comment updated successfully");
                }
                else
                {
                    return StatusCode(403, new Result<Article>(false, "You are not authorized."));
                }
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Comment updating");
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Result<Comment>> Delete(long id)
        {
            try
            {
                Comment data = _commentService.GetById(id);
                if (data.createdUserId == Current.user.id || Current.user.roleId == 1)
                {
                    _commentService.Remove(id);
                    _logger.LogInformation("Deleted one Comment");
                    return new Result<Comment>(true, "Comment deleted successfully");
                }
                else
                {
                    return StatusCode(403, new Result<Article>(false, "You are not authorized."));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Comment deleting");
                throw ex;
            }
        }
    }
}