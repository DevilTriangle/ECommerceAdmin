namespace AdminECommerceModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Banners = new HashSet<Banner>();
            OrderDetails = new HashSet<OrderDetail>();
            Promotions = new HashSet<Promotion>();
            Reviews = new HashSet<Review>();
            Accounts = new HashSet<Account>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public double Price { get; set; }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string Image1 { get; set; }

        [StringLength(50)]
        public string Image2 { get; set; }

        [StringLength(50)]
        public string Image3 { get; set; }

        [StringLength(50)]
        public string Image4 { get; set; }

        [StringLength(50)]
        public string Manufacturer { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string ShortDescription { get; set; }

        [StringLength(255)]
        public string OtherInfo { get; set; }

        public int Stock { get; set; }

        public DateTime DateArrivals { get; set; }

        public double? SaleOff { get; set; }

        [StringLength(255)]
        public string AttVal1 { get; set; }

        [StringLength(255)]
        public string AttVal2 { get; set; }

        [StringLength(255)]
        public string AttVal3 { get; set; }

        [StringLength(255)]
        public string AttVal4 { get; set; }

        [StringLength(255)]
        public string AttVal5 { get; set; }

        [StringLength(255)]
        public string AttVal6 { get; set; }

        [StringLength(255)]
        public string AttVal7 { get; set; }

        [StringLength(255)]
        public string AttVal8 { get; set; }

        [StringLength(255)]
        public string AttVal9 { get; set; }

        [StringLength(255)]
        public string AttVal10 { get; set; }

        public int? RatingScore { get; set; }

        public int? NumOfRates { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banner> Banners { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promotion> Promotions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
