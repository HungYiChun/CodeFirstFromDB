namespace CodeFirstFromDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewUserDetail")]
    public partial class ViewUserDetail
    {
        [Key]
        [Column(Order = 0)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string Username { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string Password { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string PhoneNumber { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime EditTime { get; set; }

        [StringLength(256)]
        public string RoleName { get; set; }

        [StringLength(256)]
        public string StatusName { get; set; }
    }
}
