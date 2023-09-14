namespace LabNetPractica3.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shippers")]
    public partial class Shippers
    {
        [Key]
        public int ShipperID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(24)]
        public string Phone { get; set; }
    }
}
