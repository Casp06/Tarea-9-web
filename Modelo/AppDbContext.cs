using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Vivencia> Vivencias { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vivencia>()
            .HasOne<Usuario>()
            .WithMany()
            .HasForeignKey(v => v.UsuarioId);
    }
}

