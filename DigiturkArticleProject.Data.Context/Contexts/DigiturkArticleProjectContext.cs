using DigiturkArticleProject.Data.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Context.Contexts
{
    public class DigiturkArticleProjectContext : DbContext
    {
        public DigiturkArticleProjectContext(DbContextOptions<DigiturkArticleProjectContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleSystemAction> RoleSystemAction { get; set; }
        public DbSet<SystemAction> SystemAction { get; set; }
        public DbSet<User> User { get; set; }
    }
}
