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

namespace DigiturkSystemActionProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemActionController : ControllerBase
    {
        private readonly SystemActionService _systemActionService;
        private readonly ILogger _logger;

        public SystemActionController(ILogger<SystemActionController> logger, IRepository<SystemAction> systemActionRepository)
        {
            _systemActionService = (SystemActionService)systemActionRepository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Result<List<SystemAction>>> Get()
        {
            try
            {
                List<SystemAction> systemActions = _systemActionService.Get();
                _logger.LogInformation("Get all SystemActions");
                return new Result<List<SystemAction>>(true, "", systemActions);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on SystemActions getting");
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Result<SystemAction>> Get(long id)
        {
            try
            {
                SystemAction systemAction = _systemActionService.GetById(id);
                _logger.LogInformation("Get one SystemAction");
                return new Result<SystemAction>(true, "", systemAction);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on SystemAction getting");
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult<Result<SystemAction>> Post([FromBody]SystemAction model)
        {
            try
            {
                _systemActionService.Add(model);
                _logger.LogInformation("Added one SystemAction");
                return new Result<SystemAction>(true, "SystemAction added successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on SystemAction adding");
                throw ex;
            }
        }

        [HttpPatch("{id}")]
        public ActionResult<Result<SystemAction>> Patch(long id, [FromBody]SystemAction model)
        {
            try
            {
                _systemActionService.Update(model, id);
                _logger.LogInformation("Updated one SystemAction");
                return new Result<SystemAction>(true, "SystemAction updated successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on SystemAction updating");
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Result<SystemAction>> Delete(long id)
        {
            try
            {
                _systemActionService.Remove(id);
                _logger.LogInformation("Deleted one SystemAction");
                return new Result<SystemAction>(true, "SystemAction deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred on SystemAction deleting");
                throw ex;
            }
        }
    }
}