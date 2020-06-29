namespace MyBlogSite.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int? ContentID { get; set; }

        public int? UserId { get; set; }

        public virtual Content Content { get; set; }

        public virtual User User { get; set; }
    }
}
