namespace CRUDwithMVCUsingEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentDbModel : DbContext
    {
        public StudentDbModel()
            : base("name=StudentDbModel")
        {
        }

        public virtual DbSet<Employee1> Employee1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee1>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee1>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Employee1>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
