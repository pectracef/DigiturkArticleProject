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
                return StatusCode(500, new Result<List<Comment>>(false, "Error occurred on Comments getting"));
            }
        }

        [HttpGet("{id}")]
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
                return StatusCode(500, new Result<Comment>(false, "Error occurred on Comment getting"));
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
                return StatusCode(500, new Result<Comment>(false, "Error occurred on Comment adding"));
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<Result<Comment>> Patch(long id, [FromBody]Comment model)
        {
            try
            {
                _commentService.Update(model, id);
                _logger.LogInformation("Updated one Comment");
                return new Result<Comment>(true, "Comment updated successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Comment updating");
                return StatusCode(500, new Result<Comment>(false, "Error occurred on Comment updating"));
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Result<Comment>> Delete(long id)
        {
            try
            {
                _commentService.Remove(id);
                _logger.LogInformation("Deleted one Comment");
                return new Result<Comment>(true, "Comment deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Comment deleting");
                return StatusCode(500, new Result<Comment>(false, "Error occurred on Comment deleting"));
            }
        }
    }
}