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

namespace DigiturkRoleSystemActionProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleSystemActionController : ControllerBase
    {
        private readonly RoleSystemActionService _roleSystemActionService;
        private readonly ILogger _logger;

        public RoleSystemActionController(ILogger<RoleSystemActionController> logger, IRepository<RoleSystemAction> roleSystemActionRepository)
        {
            _roleSystemActionService = (RoleSystemActionService)roleSystemActionRepository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Result<List<RoleSystemAction>>> Get()
        {
            try
            {
                List<RoleSystemAction> roleSystemActions = _roleSystemActionService.Get();
                _logger.LogInformation("Get all RoleSystemActions");
                return new Result<List<RoleSystemAction>>(true, "", roleSystemActions);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on RoleSystemActions getting");
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Result<RoleSystemAction>> Get(long id)
        {
            try
            {
                RoleSystemAction roleSystemAction = _roleSystemActionService.GetById(id);
                _logger.LogInformation("Get one RoleSystemAction");
                return new Result<RoleSystemAction>(true, "", roleSystemAction);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on RoleSystemAction getting");
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult<Result<RoleSystemAction>> Post([FromBody]RoleSystemAction model)
        {
            try
            {
                _roleSystemActionService.Add(model);
                _logger.LogInformation("Added one RoleSystemAction");
                return new Result<RoleSystemAction>(true, "RoleSystemAction added successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on RoleSystemAction adding");
                throw ex;
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<Result<RoleSystemAction>> Patch(long id, [FromBody]RoleSystemAction model)
        {
            try
            {
                _roleSystemActionService.Update(model, id);
                _logger.LogInformation("Updated one RoleSystemAction");
                return new Result<RoleSystemAction>(true, "RoleSystemAction updated successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on RoleSystemAction updating");
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Result<RoleSystemAction>> Delete(long id)
        {
            try
            {
                _roleSystemActionService.Remove(id);
                _logger.LogInformation("Deleted one RoleSystemAction");
                return new Result<RoleSystemAction>(true, "RoleSystemAction deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on RoleSystemAction deleting");
                throw ex;
            }
        }
    }
}