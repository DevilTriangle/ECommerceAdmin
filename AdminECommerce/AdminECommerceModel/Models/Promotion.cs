namespace AdminECommerceModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Promotion
    {
        [StringLength(50)]
        public string Id { get; set; }

        public double Discount { get; set; }

        public string Description { get; set; }

        public int Type { get; set; }

        [StringLength(50)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountID { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public virtual Product Product { get; set; }
    }
}
