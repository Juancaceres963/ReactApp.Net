using Microsoft.EntityFrameworkCore;

namespace AndreinaArtistica.Models.DB;

public partial class AndreinartisticaContext : DbContext
{
    public AndreinartisticaContext()
    {
    }

    public AndreinartisticaContext(DbContextOptions<AndreinartisticaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ArtPiece> ArtPieces { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=JUANCACERES963\\SQLEXPRESS; DataBase=Andreinartistica; Trusted_Connection=SSPI; MultipleActiveResultSets=True; Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArtPiece>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ArtPiece__3214EC077DCAEAE1");

            entity.Property(e => e.Availability)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Exhibited)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.ArtPieces)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArtPieces_Categories");

            entity.HasOne(d => d.MaterialNavigation).WithMany(p => p.ArtPieces)
                .HasForeignKey(d => d.Material)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArtPieces_Materials");

            entity.HasOne(d => d.TopicNavigation).WithMany(p => p.ArtPieces)
                .HasForeignKey(d => d.Topic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArtPieces_Subjects");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07D8911B9A");

            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Material__3214EC074292B980");

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subjects__3214EC07A1B4D20C");

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
