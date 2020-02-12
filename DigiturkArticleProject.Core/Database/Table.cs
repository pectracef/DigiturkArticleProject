using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace DigiturkArticleProject.Core.Database
{
    public abstract class Table
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        [JsonIgnore]
        public bool isDeleted { get; set; }
    }
}
