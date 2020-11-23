using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#nullable disable

namespace Projet_final.Models
{
    public partial class BDW56_424qContext : IdentityDbContext
    {
        public BDW56_424qContext()
        {
        }

        public BDW56_424qContext(DbContextOptions<BDW56_424qContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acteur> Acteurs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<EmpruntsFilm> EmpruntsFilms { get; set; }
        public virtual DbSet<Exemplaire> Exemplaires { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmsActeur> FilmsActeurs { get; set; }
        public virtual DbSet<FilmsLangue> FilmsLangues { get; set; }
        public virtual DbSet<FilmsSousTitre> FilmsSousTitres { get; set; }
        public virtual DbSet<FilmsSupplement> FilmsSupplements { get; set; }
        public virtual DbSet<Format> Formats { get; set; }
        public virtual DbSet<Langue> Langues { get; set; }
        public virtual DbSet<Preference> Preferences { get; set; }
        public virtual DbSet<Producteur> Producteurs { get; set; }
        public virtual DbSet<Realisateur> Realisateurs { get; set; }
        public virtual DbSet<SousTitre> SousTitres { get; set; }
        public virtual DbSet<Supplement> Supplements { get; set; }
        public virtual DbSet<TypesUtilisateur> TypesUtilisateurs { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<UtilisateursPreference> UtilisateursPreferences { get; set; }
        public virtual DbSet<ValeursPreference> ValeursPreferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDW56_424q;Persist Security Info=True;User ID=W56equipe424q;Password=Secret16113");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acteur>(entity =>
            {
                entity.HasKey(e => e.NoActeur)
                    .HasName("PK__Acteurs__CB0476852FC99B98");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Sexe)
                    .HasMaxLength(1)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.NoCategorie)
                    .HasName("PK__Categori__8F1253B91D8BD16A");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<EmpruntsFilm>(entity =>
            {
                entity.HasKey(e => e.NoExemplaire)
                    .HasName("PK__Emprunts__9D25C47A502EF3EB");

                entity.Property(e => e.NoExemplaire).ValueGeneratedOnAdd();

                entity.Property(e => e.DateEmprunt).HasColumnType("datetime");

                entity.HasOne(d => d.NoExemplaireNavigation)
                    .WithOne(p => p.EmpruntsFilm)
                    .HasForeignKey<EmpruntsFilm>(d => d.NoExemplaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpruntsF__NoExe__74444068");

                entity.HasOne(d => d.NoUtilisateurNavigation)
                    .WithMany(p => p.EmpruntsFilms)
                    .HasForeignKey(d => d.NoUtilisateur)
                    .HasConstraintName("FK__EmpruntsF__NoUti__753864A1");
            });

            modelBuilder.Entity<Exemplaire>(entity =>
            {
                entity.HasKey(e => e.NoExemplaire)
                    .HasName("PK__Exemplai__9D25C47AFB341C1E");

                entity.HasOne(d => d.NoUtilisateurProprietaireNavigation)
                    .WithMany(p => p.Exemplaires)
                    .HasForeignKey(d => d.NoUtilisateurProprietaire)
                    .HasConstraintName("FK__Exemplair__NoUti__7167D3BD");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.NoFilm)
                    .HasName("PK__Films__0925D31B18A53236");

                entity.Property(e => e.DataMaj)
                    .HasColumnType("datetime")
                    .HasColumnName("DataMAJ");

                entity.Property(e => e.ImagePochette).HasMaxLength(50);

                entity.Property(e => e.NoUtilisateurMaj).HasColumnName("NoUtilisateurMAJ");

                entity.Property(e => e.Resume).HasMaxLength(500);

                entity.Property(e => e.TitreFrancais).HasMaxLength(50);

                entity.Property(e => e.TitreOriginal).HasMaxLength(50);

                entity.Property(e => e.Xtra).HasMaxLength(255);

                entity.HasOne(d => d.CategorieNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.Categorie)
                    .HasConstraintName("FK__Films__Categorie__5B78929E");

                entity.HasOne(d => d.FormatNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.Format)
                    .HasConstraintName("FK__Films__Format__5C6CB6D7");

                entity.HasOne(d => d.NoProducteurNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.NoProducteur)
                    .HasConstraintName("FK__Films__NoProduct__5D60DB10");

                entity.HasOne(d => d.NoRealisateurNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.NoRealisateur)
                    .HasConstraintName("FK__Films__NoRealisa__5E54FF49");

                entity.HasOne(d => d.NoUtilisateurMajNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.NoUtilisateurMaj)
                    .HasConstraintName("FK__Films__NoUtilisa__5F492382");
            });

            modelBuilder.Entity<FilmsActeur>(entity =>
            {
                entity.HasKey(e => new { e.NoFilm, e.NoActeur })
                    .HasName("PK__FilmsAct__45959473A964F66F");

                entity.HasOne(d => d.NoActeurNavigation)
                    .WithMany(p => p.FilmsActeurs)
                    .HasForeignKey(d => d.NoActeur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsActe__NoAct__6225902D");

                entity.HasOne(d => d.NoFilmNavigation)
                    .WithMany(p => p.FilmsActeurs)
                    .HasForeignKey(d => d.NoFilm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsActe__NoFil__6319B466");
            });

            modelBuilder.Entity<FilmsLangue>(entity =>
            {
                entity.HasKey(e => new { e.NoFilm, e.NoLangue })
                    .HasName("PK__FilmsLan__E9AF0698B40E12B7");

                entity.HasOne(d => d.NoFilmNavigation)
                    .WithMany(p => p.FilmsLangues)
                    .HasForeignKey(d => d.NoFilm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsLang__NoFil__66EA454A");

                entity.HasOne(d => d.NoLangueNavigation)
                    .WithMany(p => p.FilmsLangues)
                    .HasForeignKey(d => d.NoLangue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsLang__NoLan__65F62111");
            });

            modelBuilder.Entity<FilmsSousTitre>(entity =>
            {
                entity.HasKey(e => new { e.NoFilm, e.NoSousTitre })
                    .HasName("PK__FilmsSou__12FA8392E2DB3828");

                entity.HasOne(d => d.NoFilmNavigation)
                    .WithMany(p => p.FilmsSousTitres)
                    .HasForeignKey(d => d.NoFilm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsSous__NoFil__6ABAD62E");

                entity.HasOne(d => d.NoSousTitreNavigation)
                    .WithMany(p => p.FilmsSousTitres)
                    .HasForeignKey(d => d.NoSousTitre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsSous__NoSou__69C6B1F5");
            });

            modelBuilder.Entity<FilmsSupplement>(entity =>
            {
                entity.HasKey(e => new { e.NoFilm, e.NoSupplement })
                    .HasName("PK__FilmsSup__AA85C2146ED1DC77");

                entity.HasOne(d => d.NoFilmNavigation)
                    .WithMany(p => p.FilmsSupplements)
                    .HasForeignKey(d => d.NoFilm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsSupp__NoFil__6E8B6712");

                entity.HasOne(d => d.NoSupplementNavigation)
                    .WithMany(p => p.FilmsSupplements)
                    .HasForeignKey(d => d.NoSupplement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmsSupp__NoSup__6D9742D9");
            });

            modelBuilder.Entity<Format>(entity =>
            {
                entity.HasKey(e => e.NoFormat)
                    .HasName("PK__Formats__14C9A89DA15EDCEF");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<Langue>(entity =>
            {
                entity.HasKey(e => e.NoLangue)
                    .HasName("PK__Langues__08AD583F35484D8F");

                entity.Property(e => e.Langue1)
                    .HasMaxLength(10)
                    .HasColumnName("Langue");
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.HasKey(e => e.NoPreference)
                    .HasName("PK__Preferen__625F5DC968AC3FF1");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<Producteur>(entity =>
            {
                entity.HasKey(e => e.NoProducteur)
                    .HasName("PK__Producte__65CE0B72B42A5E90");

                entity.Property(e => e.Nom).HasMaxLength(50);
            });

            modelBuilder.Entity<Realisateur>(entity =>
            {
                entity.HasKey(e => e.NoRealisateur)
                    .HasName("PK__Realisat__10EE19F6E790CECE");

                entity.Property(e => e.Nom).HasMaxLength(50);
            });

            modelBuilder.Entity<SousTitre>(entity =>
            {
                entity.HasKey(e => e.NoSousTitre)
                    .HasName("PK__SousTitr__BDF508907778DB85");

                entity.Property(e => e.LangueSousTitre).HasMaxLength(10);
            });

            modelBuilder.Entity<Supplement>(entity =>
            {
                entity.HasKey(e => e.NoSupplement)
                    .HasName("PK__Suppleme__3A0110FB7A8792F3");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<TypesUtilisateur>(entity =>
            {
                entity.HasKey(e => e.TypeUtilisateur)
                    .HasName("PK__TypesUti__4B039DB67195E875");

                entity.Property(e => e.TypeUtilisateur)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.Description).HasMaxLength(25);
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.NoUtilisateur)
                    .HasName("PK__Utilisat__131985C49040BA75");

                entity.Property(e => e.Courriel).HasMaxLength(50);

                entity.Property(e => e.NomUtilisateur).HasMaxLength(10);

                entity.Property(e => e.TypeUtilisateur)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.HasOne(d => d.TypeUtilisateurNavigation)
                    .WithMany(p => p.Utilisateurs)
                    .HasForeignKey(d => d.TypeUtilisateur)
                    .HasConstraintName("FK__Utilisate__TypeU__589C25F3");
            });

            modelBuilder.Entity<UtilisateursPreference>(entity =>
            {
                entity.HasKey(e => new { e.NoUtilisateur, e.NoPreference })
                    .HasName("PK__Utilisat__953C70185E5B23F9");

                entity.HasOne(d => d.NoPreferenceNavigation)
                    .WithMany(p => p.UtilisateursPreferences)
                    .HasForeignKey(d => d.NoPreference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utilisate__NoPre__79FD19BE");

                entity.HasOne(d => d.NoUtilisateurNavigation)
                    .WithMany(p => p.UtilisateursPreferences)
                    .HasForeignKey(d => d.NoUtilisateur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utilisate__NoUti__7AF13DF7");
            });

            modelBuilder.Entity<ValeursPreference>(entity =>
            {
                entity.HasKey(e => new { e.NoUtilisateur, e.NoPreference })
                    .HasName("PK__ValeursP__953C7018ADDB8EFB");

                entity.Property(e => e.Valeur).HasMaxLength(50);

                entity.HasOne(d => d.No)
                    .WithOne(p => p.ValeursPreference)
                    .HasForeignKey<ValeursPreference>(d => new { d.NoUtilisateur, d.NoPreference })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ValeursPreferenc__7DCDAAA2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
