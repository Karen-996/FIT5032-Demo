using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _5032_Demo.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<_5032_Demo.Models.MOCK_DATA> MOCK_DATA { get; set; }
    }
}
