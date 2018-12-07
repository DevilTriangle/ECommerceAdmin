namespace AdminECommerceModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Message
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column("Message")]
        public string Message1 { get; set; }

        [StringLength(50)]
        public string AccountID { get; set; }

        public bool? IsAnswered { get; set; }

        [StringLength(128)]
        public string AnsweredAccountId { get; set; }

        public string Answer { get; set; }

        public bool? Status { get; set; }

        public virtual Account Account { get; set; }
    }
}
