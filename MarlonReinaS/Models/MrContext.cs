

namespace MarlonReinaS.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Reflection.Emit;
    using System.Web;

    public class MrContext : DbContext
    {
        public MrContext(): base("MrContext")
        {

        }

        public DbSet<Ciudad> Ciudads{ get; set; }
        public DbSet<Vendedor> Vendedors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Ciudad>()
            //         .HasMany<Vendedor>(g => g.Vendedors)
            //         .WithRequired(s => s.Ciudads)
            //         .WillCascadeOnDelete();
        }
    }
}