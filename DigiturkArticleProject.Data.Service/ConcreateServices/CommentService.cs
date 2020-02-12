using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Service.ConcreateServices
{
    public class CommentService : Repository<Comment>
    {
        public CommentService(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}
