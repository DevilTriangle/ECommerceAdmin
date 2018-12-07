namespace AdminECommerceModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductID { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double SaleOff { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
