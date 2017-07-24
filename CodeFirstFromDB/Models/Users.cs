namespace CodeFirstFromDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public string Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [Required]
        [StringLength(256)]
        public string Password { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string PhoneNumber { get; set; }

        public DateTime EditTime { get; set; }

        public virtual Roles Roles { get; set; }

        public virtual Status Status { get; set; }
    }
}
