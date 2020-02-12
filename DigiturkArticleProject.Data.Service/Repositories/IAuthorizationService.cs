using DigiturkArticleProject.Data.Model.Authentication;
using DigiturkArticleProject.Data.Model.Authorization;
using DigiturkArticleProject.Data.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Service.Repositories
{
    public interface IAuthorizationService
    {
        Authorize Get(string token);
    }
}
