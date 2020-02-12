using DigiturkArticleProject.Data.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Model.Authorization
{
    public class Authorize
    {
        public User user { get; set; }
        public List<SystemAction> authorizedActions { get; set; }
    }
}
