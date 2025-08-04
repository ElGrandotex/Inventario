using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Inventario.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Categorias)
                .HasForeignKey(e => e.CategoriaId)
                .WillCascadeOnDelete(false);
        }
    }
}
