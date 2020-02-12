using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkArticleProject.Core.Infrastructure;
using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.ConcreateServices;
using DigiturkArticleProject.Data.Service.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DigiturkUserProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly ILogger _logger;

        public UserController(ILogger<UserController> logger, IRepository<User> userRepository)
        {
            _userService = (UserService)userRepository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Result<List<User>>> Get()
        {
            try
            {
                List<User> users = _userService.Get();
                _logger.LogInformation("Get all Users");
                return new Result<List<User>>(true, "", users);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Users getting");
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Result<User>> Get(long id)
        {
            try
            {
                User user = _userService.GetById(id);
                _logger.LogInformation("Get one User");
                return new Result<User>(true, "", user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on User getting");
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult<Result<User>> Post([FromBody]User model)
        {
            try
            {
                _userService.Add(model);
                _logger.LogInformation("Added one User");
                return new Result<User>(true, "User added successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on User adding");
                throw ex;
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<Result<User>> Patch(long id, [FromBody]User model)
        {
            try
            {
                _userService.Update(model, id);
                _logger.LogInformation("Updated one User");
                return new Result<User>(true, "User updated successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on User updating");
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Result<User>> Delete(long id)
        {
            try
            {
                _userService.Remove(id);
                _logger.LogInformation("Deleted one User");
                return new Result<User>(true, "User deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on User deleting");
                throw ex;
            }
        }
    }
}