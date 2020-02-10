using DigiturkArticleProject.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiturkArticleProject.Data.Model.Entities
{
    public class RoleSystemAction : Table
    {
        public ulong roleId { get; set; }
        public ulong systemActionId { get; set; }

        [ForeignKey(nameof(roleId))]
        public virtual Role role { get; set; }
        [ForeignKey(nameof(systemActionId))]
        public virtual SystemAction systemAction { get; set; }
    }
}
