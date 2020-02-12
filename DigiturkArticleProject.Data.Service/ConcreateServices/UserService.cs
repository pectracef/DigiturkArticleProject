using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Service.ConcreateServices
{
    public class UserService : Repository<User>
    {
        public UserService(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}
