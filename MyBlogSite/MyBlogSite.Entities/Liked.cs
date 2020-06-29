namespace MyBlogSite.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Liked")]
    public partial class Liked
    {
        public int Id { get; set; }

        public int? ContentId { get; set; }

        public int? UserId { get; set; }

        public virtual Content Content { get; set; }

        public virtual User User { get; set; }
    }
}
