using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkArticleProject.Core.Infrastructure;
using DigiturkArticleProject.Core.Infrastructure.Extensions;
using DigiturkArticleProject.Data.Model.Authentication;
using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.ConcreateServices;
using DigiturkArticleProject.Data.Service.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigiturkArticleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService userService;
        public AuthController(IRepository<User> userRepository)
        {
            userService = (UserService)userRepository;
        }

        [HttpPost("login")]
        public ActionResult<Result<LoginResponse>> Login([FromBody]LoginRequest request)
        {
            if (!string.IsNullOrEmpty(request.username) && !string.IsNullOrEmpty(request.password))
            {
                request.password = request.password.ToSHA256();
                User user = userService.GetSingle(c => c.username.Equals(request.username) && c.password.Equals(request.password));
                if(user != null)
                {
                    return new Result<LoginResponse>(true, "Login successfully", new LoginResponse()
                    {
                        token = new Token()
                        {
                            expireDate = request.isRemember ? DateTime.Now.AddMonths(1) : DateTime.Now.AddMinutes(20),
                            userId = user.id
                        }
                        .ToJson()
                        .ToRijndael()
                    });
                }
                else
                {
                    return new Result<LoginResponse>(false, "Username or password incorrect");
                }
            }
            return StatusCode(400);
        }

        [HttpPost("register")]
        public ActionResult<Result<object>> Register([FromBody]RegisterRequest request)
        {
            if(request.password == request.rePassword)
            {
                request.password = request.password.ToSHA256();
                userService.Add(new User() { 
                    username = request.username,
                    password = request.password,
                    roleId = 3
                });

                return new Result<object>(true, "Register successfully");
            }
            else
            {
                return new Result<object>(false, "Passwords must be same");
            }
        }
    }
}