﻿using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Service.ConcreateServices
{
    public class RoleService : Repository<Role>
    {
        public RoleService(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}
