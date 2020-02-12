using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.ConcreateServices;
using DigiturkArticleProject.Data.Service.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Service.ServiceExtensions
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddDbContextService();
            services.AddTransient<IRepository<Article>, ArticleService>();
            services.AddTransient<IRepository<Comment>, CommentService>();
            services.AddTransient<IRepository<Role>, RoleService>();
            services.AddTransient<IRepository<RoleSystemAction>, RoleSystemActionService>();
            services.AddTransient<IRepository<SystemAction>, SystemActionService>();
            services.AddTransient<IRepository<User>, UserService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            return services;
        }
    }
}
