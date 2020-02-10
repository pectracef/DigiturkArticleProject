using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiturkArticleProject.Core.Database
{
    public abstract class Table
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public bool isDeleted { get; set; }
    }
}
