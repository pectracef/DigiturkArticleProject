using System;
using System.Collections.Generic;
using System.Text;

namespace DigiturkArticleProject.Data.Model.Authentication
{
    public class Token
    {
        public long userId { get; set; }
        public DateTime expireDate { get; set; }
    }
}
