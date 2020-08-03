namespace ItlaSigno.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SignoModel : DbContext
    {
        public SignoModel()
            : base("name=SignoModel3")
        {
        }

        public virtual DbSet<Signo> Signoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Signo>()
                .Property(e => e.UsuarioId)
                .IsFixedLength();

            modelBuilder.Entity<Signo>()
                .Property(e => e.UsuarioNombre)
                .IsFixedLength();

            modelBuilder.Entity<Signo>()
                .Property(e => e.UsuarioApellido)
                .IsFixedLength();

            modelBuilder.Entity<Signo>()
                .Property(e => e.UsuarioCedula)
                .IsFixedLength();
        }
    }
}
