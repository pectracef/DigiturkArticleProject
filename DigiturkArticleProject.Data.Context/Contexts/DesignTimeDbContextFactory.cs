using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DigiturkArticleProject.Data.Context.Contexts
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DigiturkArticleProjectContext>
    {
        public DigiturkArticleProjectContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DigiturkArticleProjectContext>();
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DigiturkArticleProject.API"))
                .AddJsonFile("appsettings.json")
                .Build();
            builder.UseSqlServer(configuration.GetConnectionString("DB"));
            return new DigiturkArticleProjectContext(builder.Options);
        }
    }
}
