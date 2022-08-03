using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _5032_Demo.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<MOCK_DATA> MOCK_DATA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.medicine)
                .IsUnicode(false);
        }
    }
}
