namespace AdminECommerceModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string AttName1 { get; set; }

        [StringLength(255)]
        public string AttName2 { get; set; }

        [StringLength(255)]
        public string AttName3 { get; set; }

        [StringLength(255)]
        public string AttName4 { get; set; }

        [StringLength(255)]
        public string AttName5 { get; set; }

        [StringLength(255)]
        public string AttName6 { get; set; }

        [StringLength(255)]
        public string AttName7 { get; set; }

        [StringLength(255)]
        public string AttName8 { get; set; }

        [StringLength(255)]
        public string AttName9 { get; set; }

        [StringLength(255)]
        public string AttName10 { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
