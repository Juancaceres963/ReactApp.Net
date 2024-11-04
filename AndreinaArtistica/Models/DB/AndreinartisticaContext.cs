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

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<Technique> Techniques { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categories__3214EC07D8911B9A");
            entity.Property(e => e.Name)
                  .HasMaxLength(20)
                  .IsUnicode(false);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Materials__3214EC074292B980");
            entity.Property(e => e.Name)
                  .HasMaxLength(30)
                  .IsUnicode(false);
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Topics__3214EC07A1B4D20C");
            entity.Property(e => e.Name)
                  .HasMaxLength(30)
                  .IsUnicode(false);
        });

        modelBuilder.Entity<Technique>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Techniques__3214EC07A1B4D20C"); 
            entity.Property(e => e.Name)
                  .HasMaxLength(30)
                  .IsUnicode(false);
        });

        modelBuilder.Entity<ArtPiece>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ArtPieces__3214EC077DCAEAE1");
            entity.Property(e => e.Availability).HasColumnType("bit");
            entity.Property(e => e.Exhibited).HasMaxLength(200).IsUnicode(false);
            entity.Property(e => e.State).HasMaxLength(20).IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(150).IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(200).IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)"); // Specify precision for Price

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
                  .HasConstraintName("FK_ArtPieces_Topics");

            entity.HasOne(d => d.TechniqueNavigation).WithMany(p => p.ArtPieces)
                  .HasForeignKey(d => d.Technique)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_ArtPieces_Techniques");
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
