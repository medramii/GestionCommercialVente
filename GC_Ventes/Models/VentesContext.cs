using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class VentesContext : DbContext
    {
        public VentesContext()
        {
        }

        public VentesContext(DbContextOptions<VentesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MdiGroupeUtilisateur> MdiGroupeUtilisateurs { get; set; }
        public virtual DbSet<MdiUtilisateur> MdiUtilisateurs { get; set; }
        public virtual DbSet<WebDroitUser> WebDroitUsers { get; set; }
        public virtual DbSet<WebPage> WebPages { get; set; }
        public object WebPage { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ROMERROLAPTOP;Database=Ventes;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<MdiGroupeUtilisateur>(entity =>
            {
                entity.ToTable("MDI_GroupeUtilisateurs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESIGNATION");

                entity.Property(e => e.Supprimer).HasColumnName("SUPPRIMER");
            });

            modelBuilder.Entity<MdiUtilisateur>(entity =>
            {
                entity.ToTable("MDI_Utilisateurs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gsm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSM");

                entity.Property(e => e.IdGroupe).HasColumnName("ID_GROUPE");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM");

                entity.Property(e => e.Online).HasColumnName("ONLINE");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASS");

                entity.Property(e => e.Photo)
                    .HasColumnType("image")
                    .HasColumnName("PHOTO");

                entity.Property(e => e.Poste)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTE");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM");

                entity.Property(e => e.Pseudo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PSEUDO");

                entity.Property(e => e.Supprimer).HasColumnName("SUPPRIMER");

                entity.Property(e => e.Theme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("THEME");

                entity.HasOne(d => d.IdGroupeNavigation)
                    .WithMany(p => p.MdiUtilisateurs)
                    .HasForeignKey(d => d.IdGroupe)
                    .HasConstraintName("FK_MDI_Utilisateurs_MDI_GroupeUtilisateurs");
            });

            modelBuilder.Entity<WebDroitUser>(entity =>
            {
                entity.ToTable("Web_DroitUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Droit).HasColumnName("droit");

                entity.Property(e => e.IdGoup).HasColumnName("idGoup");

                entity.Property(e => e.IdPage).HasColumnName("idPage");

                entity.HasOne(d => d.IdGoupNavigation)
                    .WithMany(p => p.WebDroitUsers)
                    .HasForeignKey(d => d.IdGoup)
                    .HasConstraintName("FK_Web_DroitUser_MDI_GroupeUtilisateurs");

                entity.HasOne(d => d.IdPageNavigation)
                    .WithMany(p => p.WebDroitUsers)
                    .HasForeignKey(d => d.IdPage)
                    .HasConstraintName("FK_Web_DroitUser_Web_Pages");
            });

            modelBuilder.Entity<WebPage>(entity =>
            {
                entity.ToTable("Web_Pages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Page)
                    .HasMaxLength(50)
                    .HasColumnName("page");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}