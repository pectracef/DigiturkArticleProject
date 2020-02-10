using DigiturkArticleProject.Core.Database;

namespace DigiturkArticleProject.Data.Model.Entities
{
    public class SystemAction : Table
    {
        public string controllerName { get; set; }
        public string actionName { get; set; }
    }
}
