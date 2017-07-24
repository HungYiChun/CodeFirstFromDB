namespace CodeFirstFromDB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CodeFirstDBModel : DbContext
    {
        public CodeFirstDBModel()
            : base("name=CodeFirstDBModel")
        {
        }

        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ViewUserDetail> ViewUserDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
