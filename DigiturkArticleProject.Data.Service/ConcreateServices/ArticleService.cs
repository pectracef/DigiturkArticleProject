using DigiturkArticleProject.Core.Infrastructure;
using DigiturkArticleProject.Data.Model.Entities;
using DigiturkArticleProject.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiturkArticleProject.Data.Service.ConcreateServices
{
    public class ArticleService : Repository<Article>
    {
        public ArticleService(IServiceProvider serviceProvider):base(serviceProvider)
        {

        }

        public Result<List<Article>> Search(string query)
        {
            try
            {
                List<Article> result = this._context.Article.Where(c => c.title.Contains(query) || c.subTitle.Contains(query) || c.content.Contains(query)).ToList();
                return new Result<List<Article>>(true, "", result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
