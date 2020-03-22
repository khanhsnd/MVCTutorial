namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? IdType { get; set; }

        public double? Price { get; set; }

        [StringLength(20)]
        public string Color { get; set; }

        [Column(TypeName = "text")]
        public string Parameter { get; set; }

        [Column(TypeName = "text")]
        public string Note { get; set; }

        public int? IdPromotion { get; set; }

        public int? Status { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? Modified { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual Type Type { get; set; }
    }
}
