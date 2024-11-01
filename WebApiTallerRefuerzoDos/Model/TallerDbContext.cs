namespace WebApiTallerRefuerzoDos.Model
{
    using Microsoft.EntityFrameworkCore;

    public class TallerDbContex : DbContext
    {
        public TallerDbContex(DbContextOptions<TallerDbContex> options) : base(options) { }

        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(g => g.Id);
                entity.Property(g => g.Nombre).IsRequired().HasMaxLength(255);
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Nombre).IsRequired().HasMaxLength(255);
                entity.Property(c => c.Telefono).HasMaxLength(50);

                // Configuración de la relación con Grupo
                entity.HasOne(c => c.Grupo)
                      .WithMany(g => g.Contactos)
                      .HasForeignKey(c => c.GrupoId)
                      .OnDelete(DeleteBehavior.SetNull); // `ON DELETE SET NULL`
            });
        }
    }

}
