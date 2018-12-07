namespace AdminECommerceModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Contact
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(50)]
        public string LandLine { get; set; }

        [StringLength(50)]
        public string CellPhone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Skype { get; set; }

        [StringLength(255)]
        public string Facebook { get; set; }

        [StringLength(255)]
        public string Gmail { get; set; }

        [StringLength(255)]
        public string Twitter { get; set; }

        [StringLength(255)]
        public string Instagram { get; set; }

        [StringLength(255)]
        public string Working { get; set; }

        [StringLength(50)]
        public string AccountID { get; set; }

        public virtual Account Account { get; set; }
    }
}
