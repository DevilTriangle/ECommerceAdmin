namespace AdminECommerceModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Review
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(50)]
        public string AccountId { get; set; }

        public string Content { get; set; }

        public int? Rating { get; set; }

        public bool? IsActive { get; set; }

        public virtual Account Account { get; set; }

        public virtual Product Product { get; set; }
    }
}
