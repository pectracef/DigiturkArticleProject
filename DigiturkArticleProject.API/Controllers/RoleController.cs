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

namespace DigiturkRoleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleService _roleService;
        private readonly ILogger _logger;

        public RoleController(ILogger<RoleController> logger, IRepository<Role> roleRepository)
        {
            _roleService = (RoleService)roleRepository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Result<List<Role>>> Get()
        {
            try
            {
                List<Role> roles = _roleService.Get();
                _logger.LogInformation("Get all Roles");
                return new Result<List<Role>>(true, "", roles);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Roles getting");
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Result<Role>> Get(long id)
        {
            try
            {
                Role role = _roleService.GetById(id);
                _logger.LogInformation("Get one Role");
                return new Result<Role>(true, "", role);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Role getting");
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult<Result<Role>> Post([FromBody]Role model)
        {
            try
            {
                _roleService.Add(model);
                _logger.LogInformation("Added one Role");
                return new Result<Role>(true, "Role added successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Role adding");
                throw ex;
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<Result<Role>> Patch(long id, [FromBody]Role model)
        {
            try
            {
                _roleService.Update(model, id);
                _logger.LogInformation("Updated one Role");
                return new Result<Role>(true, "Role updated successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Role updating");
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Result<Role>> Delete(long id)
        {
            try
            {
                _roleService.Remove(id);
                _logger.LogInformation("Deleted one Role");
                return new Result<Role>(true, "Role deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on Role deleting");
                throw ex;
            }
        }
    }
}