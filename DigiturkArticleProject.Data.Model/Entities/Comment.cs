using DigiturkArticleProject.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiturkArticleProject.Data.Model.Entities
{
    public class Comment : Table
    {
        public long? parentCommentId { get; set; }
        public long articleId { get; set; }
        public string content { get; set; }
        public long? createdUserId { get; set; }

        [ForeignKey(nameof(parentCommentId))]
        public virtual Comment parentComment { get; set; }
        [ForeignKey(nameof(articleId))]
        public virtual Article article { get; set; }
        [ForeignKey(nameof(createdUserId))]
        public virtual User createdUser { get; set; }
    }
}
