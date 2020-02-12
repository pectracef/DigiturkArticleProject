using DigiturkArticleProject.Data.Context.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DigiturkArticleProject.Data.Service.ServiceExtensions
{
    static class DbContextService
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider();
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DigiturkArticleProject.API"))
                .AddJsonFile("appsettings.json")
                .Build();
            services.AddDbContext<DigiturkArticleProjectContext>(x => x.UseSqlServer(configuration.GetConnectionString("DB")));
            return services;
        }
    }
}
