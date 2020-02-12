using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Model.Authentication
{
    public class LoginRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool isRemember { get; set; }
    }

    public class LoginResponse
    {
        public string token { get; set; }
    }
}
