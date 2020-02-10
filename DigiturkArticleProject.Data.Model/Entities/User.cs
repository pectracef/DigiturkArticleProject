using DigiturkArticleProject.Core.Database;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiturkArticleProject.Data.Model.Entities
{
    public class User : Table
    {
        public string username { get; set; }
        public string password { get; set; }
        public ulong roleId { get; set; }

        [ForeignKey(nameof(roleId))]
        public Role role { get; set; }
    }
}
