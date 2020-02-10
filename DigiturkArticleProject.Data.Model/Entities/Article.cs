using DigiturkArticleProject.Core.Database;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiturkArticleProject.Data.Model.Entities
{
    public class Article : Table
    {
        public string title { get; set; }
        public string subTitle { get; set; }
        public string content { get; set; }
        public ulong createdUserId { get; set; }
        public ulong updatedUserId { get; set; }

        [ForeignKey(nameof(createdUserId))]
        public virtual User createdUser { get; set; }
        [ForeignKey(nameof(updatedUserId))]
        public virtual User updatedUser { get; set; }

        public virtual List<Comment> comments { get; set; }
    }
}
