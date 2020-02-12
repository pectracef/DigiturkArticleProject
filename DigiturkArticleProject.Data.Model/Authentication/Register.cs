using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Model.Authentication
{
    public class RegisterRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public string rePassword { get; set; }
    }
}
