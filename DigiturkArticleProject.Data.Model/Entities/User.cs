using DigiturkArticleProject.Core.Database;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DigiturkArticleProject.Data.Model.Entities
{
    public class User : Table
    {
        public string username { get; set; }
        [JsonIgnore]
        public string password { get; set; }
        [JsonIgnore]
        public long roleId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(roleId))]
        public Role role { get; set; }
    }
}
