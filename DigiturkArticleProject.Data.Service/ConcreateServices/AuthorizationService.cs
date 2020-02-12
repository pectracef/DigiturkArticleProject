using DigiturkArticleProject.Core.Infrastructure.Extensions;
using DigiturkArticleProject.Data.Context.Contexts;
using DigiturkArticleProject.Data.Model.Authentication;
using DigiturkArticleProject.Data.Model.Authorization;
using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.Repositories;
using DigiturkArticleProject.Data.Service.ServiceExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiturkArticleProject.Data.Service.ConcreateServices
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly DigiturkArticleProjectContext _context;
        public AuthorizationService(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<DigiturkArticleProjectContext>();
        }

        public Authorize Get(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                Token modelToken = token.FromRijndael<Token>();
                if (modelToken.expireDate > DateTime.Now)
                {
                    User user = _context.User.FirstOrDefault(c => c.id.Equals(modelToken.userId));
                    if (user != null)
                    {
                        return new Authorize()
                        {
                            user = user,
                            authorizedActions = _context.RoleSystemAction.Include(c => c.systemAction).Where(c => c.roleId.Equals(user.roleId)).Select(c => c.systemAction).ToList()
                        };
                    }
                }
            }

            return null;
        }
    }
}
