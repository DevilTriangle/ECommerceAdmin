namespace AdminECommerceModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Banner
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        public virtual Product Product { get; set; }
    }
}
