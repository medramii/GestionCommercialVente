using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class WEB_GC_Context : DbContext
    {
        public WEB_GC_Context()
        {
        }

        public WEB_GC_Context(DbContextOptions<WEB_GC_Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<MdiGroupeUtilisateur> MdiGroupeUtilisateurs { get; set; }
        public virtual DbSet<MdiUtilisateur> MdiUtilisateurs { get; set; }
        public virtual DbSet<WebDroitUser> WebDroitUsers { get; set; }
        public virtual DbSet<WebPage> WebPages { get; set; }
        public virtual DbSet<_0000BanquesSociete> _0000BanquesSocietes { get; set; }
        public virtual DbSet<_0000PieceCommerciale> _0000PieceCommerciales { get; set; }
        public virtual DbSet<_0000ReferencePiece> _0000ReferencePieces { get; set; }
        public virtual DbSet<_0000Service> _0000Services { get; set; }
        public virtual DbSet<_0000Societe> _0000Societes { get; set; }
        public virtual DbSet<_0000Tva> _0000Tvas { get; set; }
        public virtual DbSet<_0000Ville> _0000Villes { get; set; }
        public virtual DbSet<_0101DevisFournisseur> _0101DevisFournisseurs { get; set; }
        public virtual DbSet<_0102DemandeAchat> _0102DemandeAchats { get; set; }
        public virtual DbSet<_0102DetailDemandeAchat> _0102DetailDemandeAchats { get; set; }
        public virtual DbSet<_0102DetailDevi> _0102DetailDevis { get; set; }
        public virtual DbSet<_0102Devi> _0102Devis { get; set; }
        public virtual DbSet<_0102TypeMarchandise> _0102TypeMarchandises { get; set; }
        public virtual DbSet<_0103BonCommandeAchat> _0103BonCommandeAchats { get; set; }
        public virtual DbSet<_0103DetailBonCommandeAchat> _0103DetailBonCommandeAchats { get; set; }
        public virtual DbSet<_0104BonReception> _0104BonReceptions { get; set; }
        public virtual DbSet<_0104DetailBonReception> _0104DetailBonReceptions { get; set; }
        public virtual DbSet<_0104QualiteReception> _0104QualiteReceptions { get; set; }
        public virtual DbSet<_0105DetailFactureFournisseur> _0105DetailFactureFournisseurs { get; set; }
        public virtual DbSet<_0105FactureFournisseur> _0105FactureFournisseurs { get; set; }
        public virtual DbSet<_0105FactureFr> _0105FactureFrs { get; set; }
        public virtual DbSet<_0106BonEntree> _0106BonEntrees { get; set; }
        public virtual DbSet<_0106DetailBonEntree> _0106DetailBonEntrees { get; set; }
        public virtual DbSet<_0107BonTransfert> _0107BonTransferts { get; set; }
        public virtual DbSet<_0107DetailBonTransfert> _0107DetailBonTransferts { get; set; }
        public virtual DbSet<_0108LotStock> _0108LotStocks { get; set; }
        public virtual DbSet<_0108MvtLotStock> _0108MvtLotStocks { get; set; }
        public virtual DbSet<_0108TypeLot> _0108TypeLots { get; set; }
        public virtual DbSet<_0108TypeMvt> _0108TypeMvts { get; set; }
        public virtual DbSet<_0109DetailFraisApproche> _0109DetailFraisApproches { get; set; }
        public virtual DbSet<_0110BonLivraison> _0110BonLivraisons { get; set; }
        public virtual DbSet<_0110FactureComercial> _0110FactureComercials { get; set; }
        public virtual DbSet<_0110LigneBonLivraison> _0110LigneBonLivraisons { get; set; }
        public virtual DbSet<_0200Devise> _0200Devises { get; set; }
        public virtual DbSet<_0400Article> _0400Articles { get; set; }
        public virtual DbSet<_0400ClasseArticle> _0400ClasseArticles { get; set; }
        public virtual DbSet<_0400FamilleArticle> _0400FamilleArticles { get; set; }
        public virtual DbSet<_0400FamilleFournisseur> _0400FamilleFournisseurs { get; set; }
        public virtual DbSet<_0400FamilleNatureArticle> _0400FamilleNatureArticles { get; set; }
        public virtual DbSet<_0400Fournisseur> _0400Fournisseurs { get; set; }
        public virtual DbSet<_0400GroupeFamilleArticle> _0400GroupeFamilleArticles { get; set; }
        public virtual DbSet<_0400Magasin> _0400Magasins { get; set; }
        public virtual DbSet<_0400NatureArticle> _0400NatureArticles { get; set; }
        public virtual DbSet<_0401DetailInventaire> _0401DetailInventaires { get; set; }
        public virtual DbSet<_0401Inventaire> _0401Inventaires { get; set; }
        public virtual DbSet<_0401TypeFournisseur> _0401TypeFournisseurs { get; set; }
        public virtual DbSet<_0500CategorieIputation> _0500CategorieIputations { get; set; }
        public virtual DbSet<_0500ImputationsComptable> _0500ImputationsComptables { get; set; }
        public virtual DbSet<_0500JournauxComptable> _0500JournauxComptables { get; set; }
        public virtual DbSet<_0500PlanComptable> _0500PlanComptables { get; set; }
        public virtual DbSet<_0500RubriqueImputationG> _0500RubriqueImputationGs { get; set; }
        public virtual DbSet<_0902BonRetour> _0902BonRetours { get; set; }
        public virtual DbSet<_0902BonSortieMagasin> _0902BonSortieMagasins { get; set; }
        public virtual DbSet<_0902DetailBonRetour> _0902DetailBonRetours { get; set; }
        public virtual DbSet<_0902DetailBonSortieMagasin> _0902DetailBonSortieMagasins { get; set; }
        public virtual DbSet<_1000ModeReglement> _1000ModeReglements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ROMERROLAPTOP;Database=WEB_GC;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.CodeClient);

                entity.ToTable("Client");

                entity.Property(e => e.CodeClient)
                    .HasMaxLength(50)
                    .HasColumnName("codeClient");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(255)
                    .HasColumnName("adresse");

                entity.Property(e => e.Bloquer).HasColumnName("bloquer");

                entity.Property(e => e.CaracteristiqueTechnique)
                    .HasMaxLength(50)
                    .HasColumnName("caracteristiqueTechnique");

                entity.Property(e => e.Carealisee).HasColumnName("CARealisee");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(50)
                    .HasColumnName("codePostal");

                entity.Property(e => e.DateDerContrat)
                    .HasColumnType("datetime")
                    .HasColumnName("dateDerContrat");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("fax");

                entity.Property(e => e.FormeJuridique)
                    .HasMaxLength(50)
                    .HasColumnName("formeJuridique");

                entity.Property(e => e.Frs)
                    .HasMaxLength(50)
                    .HasColumnName("FRS");

                entity.Property(e => e.IdCompteAnalytique).HasColumnName("idCompteAnalytique");

                entity.Property(e => e.IdCompteGeneral).HasColumnName("idCompteGeneral");

                entity.Property(e => e.IdDevise).HasColumnName("idDevise");

                entity.Property(e => e.IdModReglement)
                    .HasMaxLength(50)
                    .HasColumnName("idModReglement");

                entity.Property(e => e.IdPays).HasColumnName("idPays");

                entity.Property(e => e.IdProduitFini).HasColumnName("idProduitFini");

                entity.Property(e => e.IdTypeContrat).HasColumnName("idTypeContrat");

                entity.Property(e => e.IdVille).HasColumnName("idVille");

                entity.Property(e => e.Observation)
                    .HasColumnType("text")
                    .HasColumnName("observation");

                entity.Property(e => e.PrixDerContrat).HasColumnName("prixDerContrat");

                entity.Property(e => e.RaisonSociale)
                    .HasMaxLength(50)
                    .HasColumnName("raisonSociale");

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .HasColumnName("site");

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .HasColumnName("tel");

                entity.Property(e => e.TypeClient)
                    .HasMaxLength(50)
                    .HasColumnName("typeClient");

                entity.HasOne(d => d.IdCompteGeneralNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdCompteGeneral)
                    .HasConstraintName("FK_Client_0500_Imputations_Comptables");

                entity.HasOne(d => d.IdDeviseNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdDevise)
                    .HasConstraintName("FK_Client_0200_Devise");

                entity.HasOne(d => d.IdModReglementNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdModReglement)
                    .HasConstraintName("FK_Client_1000_ModeReglement");

                entity.HasOne(d => d.IdVilleNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK_Client_0000_Ville");
            });

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

            modelBuilder.Entity<_0000BanquesSociete>(entity =>
            {
                entity.HasKey(e => e.IdCodeBanque)
                    .HasName("PK_BanquesSociete");

                entity.ToTable("0000_BanquesSociete");

                entity.Property(e => e.IdCodeBanque).HasColumnName("idCodeBanque");

                entity.Property(e => e.Agence).HasMaxLength(50);

                entity.Property(e => e.CodeBanque)
                    .HasMaxLength(20)
                    .HasColumnName("Code_Banque");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Gsm)
                    .HasMaxLength(50)
                    .HasColumnName("GSM");

                entity.Property(e => e.Interlocuteur).HasMaxLength(50);

                entity.Property(e => e.Rib)
                    .HasMaxLength(50)
                    .HasColumnName("RIB");

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            modelBuilder.Entity<_0000PieceCommerciale>(entity =>
            {
                entity.HasKey(e => e.NomTable)
                    .HasName("PK_PieceCommerciale");

                entity.ToTable("0000_PieceCommerciale");

                entity.Property(e => e.NomTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomTable");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.ElementActuel).HasColumnName("elementActuel");

                entity.Property(e => e.NbrNumero).HasColumnName("nbrNumero");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prefix");

                entity.Property(e => e.PremierElement).HasColumnName("premierElement");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("suffix");
            });

            modelBuilder.Entity<_0000ReferencePiece>(entity =>
            {
                entity.ToTable("0000_ReferencePiece");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ReferenceBonCommande)
                    .HasMaxLength(50)
                    .HasColumnName("referenceBonCommande");

                entity.Property(e => e.ReferenceBonDemandeAchat)
                    .HasMaxLength(50)
                    .HasColumnName("referenceBonDemandeAchat");

                entity.Property(e => e.ReferenceBonReception)
                    .HasMaxLength(50)
                    .HasColumnName("referenceBonReception");

                entity.Property(e => e.ReferenceBonRetour)
                    .HasMaxLength(50)
                    .HasColumnName("referenceBonRetour");

                entity.Property(e => e.ReferenceBonSortie)
                    .HasMaxLength(50)
                    .HasColumnName("referenceBonSortie");

                entity.Property(e => e.ReferenceSuiviAchat)
                    .HasMaxLength(50)
                    .HasColumnName("referenceSuiviAchat");
            });

            modelBuilder.Entity<_0000Service>(entity =>
            {
                entity.HasKey(e => e.CodeService)
                    .HasName("PK_Service_1");

                entity.ToTable("0000_Service");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designation");
            });

            modelBuilder.Entity<_0000Societe>(entity =>
            {
                entity.HasKey(e => e.RaisonSociale)
                    .HasName("PK_Societe");

                entity.ToTable("0000_Societe");

                entity.Property(e => e.RaisonSociale)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsUseSyncParam).HasColumnName("isUseSyncParam");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.OptionSte).HasMaxLength(50);

                entity.Property(e => e.OptionTva).HasColumnName("OptionTVA");

                entity.Property(e => e.Patente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PiedDePage).HasMaxLength(200);

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ville)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_0000Tva>(entity =>
            {
                entity.HasKey(e => e.TauxTva)
                    .HasName("PK_tva_1");

                entity.ToTable("0000_Tva");

                entity.Property(e => e.TauxTva).HasColumnName("tauxTva");
            });

            modelBuilder.Entity<_0000Ville>(entity =>
            {
                entity.HasKey(e => e.IdVille)
                    .HasName("PK_Ville");

                entity.ToTable("0000_Ville");

                entity.Property(e => e.IdVille).HasColumnName("idVille");

                entity.Property(e => e.Ville).HasMaxLength(50);
            });

            modelBuilder.Entity<_0101DevisFournisseur>(entity =>
            {
                entity.HasKey(e => e.NumDdevisFrs)
                    .HasName("PK_D_DEVIS_FRS");

                entity.ToTable("0101_DevisFournisseur");

                entity.Property(e => e.NumDdevisFrs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numDDevisFRS");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeFrs)
                    .HasMaxLength(10)
                    .HasColumnName("codeFrs")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeUnitee).HasColumnName("codeUnitee");

                entity.Property(e => e.Garanti)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("garanti");

                entity.Property(e => e.NumDevisFrs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numDevisFRS");

                entity.Property(e => e.Pu).HasColumnName("pu");

                entity.Property(e => e.Qte).HasColumnName("qte");
            });

            modelBuilder.Entity<_0102DemandeAchat>(entity =>
            {
                entity.HasKey(e => e.NumDemande)
                    .HasName("PK_DMND_ACHAT");

                entity.ToTable("0102_DemandeAchat");

                entity.Property(e => e.NumDemande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numDemande");

                entity.Property(e => e.CodeFrs)
                    .HasMaxLength(50)
                    .HasColumnName("codeFrs");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date");

                entity.Property(e => e.CreationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("creation_par");

                entity.Property(e => e.DateDemande)
                    .HasColumnType("datetime")
                    .HasColumnName("dateDemande");

                entity.Property(e => e.Etat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etat");

                entity.Property(e => e.ImprerssionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imprerssion_date");

                entity.Property(e => e.ImprerssionPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imprerssion_par");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lieu");

                entity.Property(e => e.Soldee).HasColumnName("soldee");

                entity.HasOne(d => d.CodeFrsNavigation)
                    .WithMany(p => p._0102DemandeAchats)
                    .HasForeignKey(d => d.CodeFrs)
                    .HasConstraintName("FK_0102_DemandeAchat_0400_Fournisseur");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p._0102DemandeAchats)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_DemandeAchat_Service");
            });

            modelBuilder.Entity<_0102DetailDemandeAchat>(entity =>
            {
                entity.HasKey(e => e.NumDetailDemande)
                    .HasName("PK_D_DMND_ACHAT");

                entity.ToTable("0102_DetailDemandeAchat");

                entity.Property(e => e.NumDetailDemande).HasColumnName("numDetailDemande");

                entity.Property(e => e.CodeAffaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeAffaire");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeNatureAchat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeNatureAchat");

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .HasColumnName("designation");

                entity.Property(e => e.Etat).HasColumnName("etat");

                entity.Property(e => e.IdCompteAnalytique).HasColumnName("idCompteAnalytique");

                entity.Property(e => e.IdCompteComtabiliteG).HasColumnName("idCompteComtabiliteG");

                entity.Property(e => e.IdTypeMarchandise).HasColumnName("idTypeMarchandise");

                entity.Property(e => e.NumDemande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numDemande");

                entity.Property(e => e.Observation)
                    .HasColumnType("text")
                    .HasColumnName("observation");

                entity.Property(e => e.QteCommandee)
                    .HasColumnName("qteCommandee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QteDemandee).HasColumnName("qteDemandee");

                entity.Property(e => e.QteStock).HasColumnName("qteStock");

                entity.HasOne(d => d.IdCompteComtabiliteGNavigation)
                    .WithMany(p => p._0102DetailDemandeAchats)
                    .HasForeignKey(d => d.IdCompteComtabiliteG)
                    .HasConstraintName("FK_DetailDemandeAchat_Imputations_Comptables");

                entity.HasOne(d => d.IdTypeMarchandiseNavigation)
                    .WithMany(p => p._0102DetailDemandeAchats)
                    .HasForeignKey(d => d.IdTypeMarchandise)
                    .HasConstraintName("FK_0102_DetailDemandeAchat_0102_TypeMarchandise");

                entity.HasOne(d => d.NumDemandeNavigation)
                    .WithMany(p => p._0102DetailDemandeAchats)
                    .HasForeignKey(d => d.NumDemande)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DetailDemandeAchat_DemandeAchat");
            });

            modelBuilder.Entity<_0102DetailDevi>(entity =>
            {
                entity.ToTable("0102_DetailDevis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeArt)
                    .HasMaxLength(50)
                    .HasColumnName("codeArt");

                entity.Property(e => e.DesignationArt)
                    .HasMaxLength(50)
                    .HasColumnName("designationArt");

                entity.Property(e => e.IdDevis).HasColumnName("idDevis");

                entity.Property(e => e.NumDa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numDA");

                entity.Property(e => e.Observation).HasColumnName("observation");

                entity.Property(e => e.PrixT).HasColumnName("prixT");

                entity.Property(e => e.PrixU).HasColumnName("prixU");

                entity.Property(e => e.Qte).HasColumnName("qte");

                entity.Property(e => e.UniteAch)
                    .HasMaxLength(50)
                    .HasColumnName("uniteAch");

                entity.HasOne(d => d.IdDevisNavigation)
                    .WithMany(p => p._0102DetailDevis)
                    .HasForeignKey(d => d.IdDevis)
                    .HasConstraintName("FK_0102_DetailDevis_0102_Devis");

                entity.HasOne(d => d.NumDaNavigation)
                    .WithMany(p => p._0102DetailDevis)
                    .HasForeignKey(d => d.NumDa)
                    .HasConstraintName("FK_0102_DetailDevis_0102_DemandeAchat");
            });

            modelBuilder.Entity<_0102Devi>(entity =>
            {
                entity.ToTable("0102_Devis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeFrs)
                    .HasMaxLength(50)
                    .HasColumnName("codeFrs");

                entity.Property(e => e.CreePar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("creePar");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreation");

                entity.Property(e => e.DateDevis)
                    .HasColumnType("datetime")
                    .HasColumnName("dateDevis");

                entity.Property(e => e.DateImpression)
                    .HasColumnType("datetime")
                    .HasColumnName("dateImpression");

                entity.Property(e => e.ImprimerPar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imprimerPar");

                entity.Property(e => e.NumDevis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numDevis");

                entity.Property(e => e.Observation)
                    .IsUnicode(false)
                    .HasColumnName("observation");

                entity.HasOne(d => d.CodeFrsNavigation)
                    .WithMany(p => p._0102Devis)
                    .HasForeignKey(d => d.CodeFrs)
                    .HasConstraintName("FK_0102_Devis_0400_Fournisseur");
            });

            modelBuilder.Entity<_0102TypeMarchandise>(entity =>
            {
                entity.ToTable("0102_TypeMarchandise");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Designation)
                    .HasMaxLength(250)
                    .HasColumnName("designation");
            });

            modelBuilder.Entity<_0103BonCommandeAchat>(entity =>
            {
                entity.HasKey(e => e.NumCommande)
                    .HasName("PK_CMD_ACHAT");

                entity.ToTable("0103_BonCommandeAchat");

                entity.Property(e => e.NumCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numCommande");

                entity.Property(e => e.CodeFrs)
                    .HasMaxLength(50)
                    .HasColumnName("codeFrs");

                entity.Property(e => e.CodeModeReg)
                    .HasMaxLength(50)
                    .HasColumnName("codeModeReg");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date");

                entity.Property(e => e.CreationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("creation_par");

                entity.Property(e => e.DateCommande)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCommande");

                entity.Property(e => e.DateEcheance)
                    .HasColumnType("date")
                    .HasColumnName("dateEcheance");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("dateLivraison");

                entity.Property(e => e.DelaiPaiement)
                    .HasMaxLength(50)
                    .HasColumnName("delaiPaiement");

                entity.Property(e => e.Etat)
                    .HasColumnName("etat")
                    .HasComment("False ==> Non Livrée\r\nTrue ==> Livrée");

                entity.Property(e => e.IdCompteComtabiliteG).HasColumnName("idCompteComtabiliteG");

                entity.Property(e => e.ImprerssionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imprerssion_date");

                entity.Property(e => e.ImprerssionPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imprerssion_par");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lieu");

                entity.Property(e => e.Livree)
                    .HasMaxLength(50)
                    .HasColumnName("livree");

                entity.Property(e => e.Observation).HasColumnName("observation");

                entity.Property(e => e.RefDevisFr).HasMaxLength(50);

                entity.Property(e => e.Remise).HasColumnName("remise");

                entity.Property(e => e.ServiceBc).HasColumnName("serviceBC");

                entity.Property(e => e.Soldee).HasColumnName("soldee");

                entity.Property(e => e.TypeAtct)
                    .HasMaxLength(50)
                    .HasColumnName("typeATCT");

                entity.HasOne(d => d.CodeFrsNavigation)
                    .WithMany(p => p._0103BonCommandeAchats)
                    .HasForeignKey(d => d.CodeFrs)
                    .HasConstraintName("FK_BonCommandeAchat_Fournisseur");

                entity.HasOne(d => d.CodeModeRegNavigation)
                    .WithMany(p => p._0103BonCommandeAchats)
                    .HasForeignKey(d => d.CodeModeReg)
                    .HasConstraintName("FK_BonCommandeAchat_ModeReglement");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p._0103BonCommandeAchats)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_BonCommandeAchat_Service");
            });

            modelBuilder.Entity<_0103DetailBonCommandeAchat>(entity =>
            {
                entity.HasKey(e => e.NumDetailComande)
                    .HasName("PK_D_BC_ACHAT");

                entity.ToTable("0103_DetailBonCommandeAchat");

                entity.Property(e => e.NumDetailComande).HasColumnName("numDetailComande");

                entity.Property(e => e.CodeAffaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeAffaire");

                entity.Property(e => e.CodeArticle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeNatureAchat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeNatureAchat");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .HasColumnName("designation");

                entity.Property(e => e.IdCompteAnalytique).HasColumnName("idCompteAnalytique");

                entity.Property(e => e.IdCompteComtabiliteG).HasColumnName("idCompteComtabiliteG");

                entity.Property(e => e.IdDevis).HasColumnName("idDevis");

                entity.Property(e => e.IdDevise).HasColumnName("idDevise");

                entity.Property(e => e.IdTypeMarchandise).HasColumnName("idTypeMarchandise");

                entity.Property(e => e.NumComande)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numComande");

                entity.Property(e => e.NumDemande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numDemande");

                entity.Property(e => e.Observation)
                    .HasColumnType("text")
                    .HasColumnName("observation");

                entity.Property(e => e.PrixAchat).HasColumnName("prixAchat");

                entity.Property(e => e.PrixHt).HasColumnName("prixHt");

                entity.Property(e => e.QteComandee).HasColumnName("qteComandee");

                entity.Property(e => e.QteLivree).HasColumnName("qteLivree");

                entity.Property(e => e.Remise).HasColumnName("remise");

                entity.Property(e => e.TauxTva).HasColumnName("tauxTva");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p._0103DetailBonCommandeAchats)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_0103_DetailBonCommandeAchat_0000_Service");

                entity.HasOne(d => d.IdCompteComtabiliteGNavigation)
                    .WithMany(p => p._0103DetailBonCommandeAchats)
                    .HasForeignKey(d => d.IdCompteComtabiliteG)
                    .HasConstraintName("FK_DetailBonCommandeAchat_Imputations_Comptables");

                entity.HasOne(d => d.IdDevisNavigation)
                    .WithMany(p => p._0103DetailBonCommandeAchats)
                    .HasForeignKey(d => d.IdDevis)
                    .HasConstraintName("FK_0103_DetailBonCommandeAchat_0102_Devis");

                entity.HasOne(d => d.IdTypeMarchandiseNavigation)
                    .WithMany(p => p._0103DetailBonCommandeAchats)
                    .HasForeignKey(d => d.IdTypeMarchandise)
                    .HasConstraintName("FK_0103_DetailBonCommandeAchat_0102_TypeMarchandise");

                entity.HasOne(d => d.NumComandeNavigation)
                    .WithMany(p => p._0103DetailBonCommandeAchats)
                    .HasForeignKey(d => d.NumComande)
                    .HasConstraintName("FK_D_BC_ACHAT_BC_ACHAT");

                entity.HasOne(d => d.NumDemandeNavigation)
                    .WithMany(p => p._0103DetailBonCommandeAchats)
                    .HasForeignKey(d => d.NumDemande)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_DetailBonCommandeAchat_DemandeAchat");

                entity.HasOne(d => d.TauxTvaNavigation)
                    .WithMany(p => p._0103DetailBonCommandeAchats)
                    .HasForeignKey(d => d.TauxTva)
                    .HasConstraintName("FK_DetailBonCommandeAchat_Tva");
            });

            modelBuilder.Entity<_0104BonReception>(entity =>
            {
                entity.HasKey(e => e.NumBr)
                    .HasName("PK_RECEPTIONS");

                entity.ToTable("0104_BonReception");

                entity.Property(e => e.NumBr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBR");

                entity.Property(e => e.CodeFrs)
                    .HasMaxLength(50)
                    .HasColumnName("codeFrs");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date");

                entity.Property(e => e.CreationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("creation_par");

                entity.Property(e => e.DateBr)
                    .HasColumnType("datetime")
                    .HasColumnName("dateBR");

                entity.Property(e => e.Etat).HasColumnName("etat");

                entity.Property(e => e.Facturee)
                    .HasMaxLength(50)
                    .HasColumnName("facturee");

                entity.Property(e => e.FraisApproche).HasColumnName("fraisApproche");

                entity.Property(e => e.ImprerssionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imprerssion_date");

                entity.Property(e => e.ImprerssionPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imprerssion_par");

                entity.Property(e => e.NumBl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBL");

                entity.Property(e => e.NumBs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBS");

                entity.Property(e => e.Observation).HasColumnName("observation");

                entity.Property(e => e.Remise).HasColumnName("remise");

                entity.Property(e => e.TypeAtct)
                    .HasMaxLength(50)
                    .HasColumnName("typeATCT");

                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.CodeFrsNavigation)
                    .WithMany(p => p._0104BonReceptions)
                    .HasForeignKey(d => d.CodeFrs)
                    .HasConstraintName("FK_BR_FRS");

                entity.HasOne(d => d.CodeMagasinNavigation)
                    .WithMany(p => p._0104BonReceptions)
                    .HasForeignKey(d => d.CodeMagasin)
                    .HasConstraintName("FK_BonReception_Magasin");
            });

            modelBuilder.Entity<_0104DetailBonReception>(entity =>
            {
                entity.HasKey(e => e.NumDbr)
                    .HasName("PK_DetailBonReception1");

                entity.ToTable("0104_DetailBonReception");

                entity.Property(e => e.NumDbr).HasColumnName("numDBR");

                entity.Property(e => e.CodeAffaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeAffaire");

                entity.Property(e => e.CodeArticle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeLot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeLot");

                entity.Property(e => e.CodeNatureAchat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeNatureAchat");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.CoutAchat).HasColumnName("coutAchat");

                entity.Property(e => e.DatePeremption)
                    .HasColumnType("date")
                    .HasColumnName("datePeremption");

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .HasColumnName("designation");

                entity.Property(e => e.Etat).HasColumnName("etat");

                entity.Property(e => e.FraisApproche).HasColumnName("fraisApproche");

                entity.Property(e => e.IdCompteAnalytique).HasColumnName("idCompteAnalytique");

                entity.Property(e => e.IdCompteComtabiliteG).HasColumnName("idCompteComtabiliteG");

                entity.Property(e => e.IdDevise).HasColumnName("idDevise");

                entity.Property(e => e.IdQualiteReception).HasColumnName("idQualiteReception");

                entity.Property(e => e.IdTypeMarchandise).HasColumnName("idTypeMarchandise");

                entity.Property(e => e.Inventorie).HasColumnName("inventorie");

                entity.Property(e => e.IsFraisApproche).HasColumnName("isFraisApproche");

                entity.Property(e => e.NumBr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBR");

                entity.Property(e => e.NumCmd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numCmd");

                entity.Property(e => e.Observation)
                    .HasColumnType("text")
                    .HasColumnName("observation");

                entity.Property(e => e.PrixAchat).HasColumnName("prixAchat");

                entity.Property(e => e.PrixHt).HasColumnName("prixHT");

                entity.Property(e => e.QteFacturee).HasColumnName("qteFacturee");

                entity.Property(e => e.QteLivree).HasColumnName("qteLivree");

                entity.Property(e => e.QteRestante).HasColumnName("qteRestante");

                entity.Property(e => e.QteSortie).HasColumnName("qteSortie");

                entity.Property(e => e.Remise).HasColumnName("remise");

                entity.Property(e => e.TauxTva).HasColumnName("tauxTva");

                entity.Property(e => e.TypeLot).HasColumnName("typeLot");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p._0104DetailBonReceptions)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_DetailBonReception_Service");

                entity.HasOne(d => d.IdCompteComtabiliteGNavigation)
                    .WithMany(p => p._0104DetailBonReceptions)
                    .HasForeignKey(d => d.IdCompteComtabiliteG)
                    .HasConstraintName("FK_DetailBonReception_Imputations_Comptables");

                entity.HasOne(d => d.IdQualiteReceptionNavigation)
                    .WithMany(p => p._0104DetailBonReceptions)
                    .HasForeignKey(d => d.IdQualiteReception)
                    .HasConstraintName("FK_0104_DetailBonReception_0104_QualiteReception");

                entity.HasOne(d => d.IdTypeMarchandiseNavigation)
                    .WithMany(p => p._0104DetailBonReceptions)
                    .HasForeignKey(d => d.IdTypeMarchandise)
                    .HasConstraintName("FK_0104_DetailBonReception_0102_TypeMarchandise");

                entity.HasOne(d => d.NumBrNavigation)
                    .WithMany(p => p._0104DetailBonReceptions)
                    .HasForeignKey(d => d.NumBr)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DetailBonReception_BonReception");

                entity.HasOne(d => d.TauxTvaNavigation)
                    .WithMany(p => p._0104DetailBonReceptions)
                    .HasForeignKey(d => d.TauxTva)
                    .HasConstraintName("FK_DetailBonReception_Tva");
            });

            modelBuilder.Entity<_0104QualiteReception>(entity =>
            {
                entity.ToTable("0104_QualiteReception");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Qualite)
                    .HasMaxLength(50)
                    .HasColumnName("qualite");
            });

            modelBuilder.Entity<_0105DetailFactureFournisseur>(entity =>
            {
                entity.HasKey(e => e.NumDetailFactureFournisseur)
                    .HasName("PK_DetailFactureFournisseur");

                entity.ToTable("0105_DetailFactureFournisseur");

                entity.Property(e => e.NumDetailFactureFournisseur).HasColumnName("numDetailFactureFournisseur");

                entity.Property(e => e.CodeAffaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeAffaire");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeNatureAchat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeNatureAchat");

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .HasColumnName("designation");

                entity.Property(e => e.Etat).HasColumnName("etat");

                entity.Property(e => e.IdCompteAnalytique).HasColumnName("idCompteAnalytique");

                entity.Property(e => e.IdCompteComtabiliteG).HasColumnName("idCompteComtabiliteG");

                entity.Property(e => e.IdDevise).HasColumnName("idDevise");

                entity.Property(e => e.NumBr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBR");

                entity.Property(e => e.NumDbr).HasColumnName("numDBR");

                entity.Property(e => e.NumFacture)
                    .HasMaxLength(50)
                    .HasColumnName("numFacture");

                entity.Property(e => e.Observation)
                    .HasColumnType("text")
                    .HasColumnName("observation");

                entity.Property(e => e.PrixAchat).HasColumnName("prixAchat");

                entity.Property(e => e.PrixAchatR).HasColumnName("prixAchatR");

                entity.Property(e => e.PrixHt).HasColumnName("prixHt");

                entity.Property(e => e.QteLivree).HasColumnName("qteLivree");

                entity.Property(e => e.Remise).HasColumnName("remise");

                entity.Property(e => e.TauxTva).HasColumnName("tauxTva");

                entity.HasOne(d => d.IdCompteComtabiliteGNavigation)
                    .WithMany(p => p._0105DetailFactureFournisseurs)
                    .HasForeignKey(d => d.IdCompteComtabiliteG)
                    .HasConstraintName("FK_DetailFactureFournisseur_Imputations_Comptables");

                entity.HasOne(d => d.NumDbrNavigation)
                    .WithMany(p => p._0105DetailFactureFournisseurs)
                    .HasForeignKey(d => d.NumDbr)
                    .HasConstraintName("FK_DetailFactureFournisseur_DetailBonReception");

                entity.HasOne(d => d.NumFactureNavigation)
                    .WithMany(p => p._0105DetailFactureFournisseurs)
                    .HasForeignKey(d => d.NumFacture)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DetailFactureFournisseur_FactureFournisseur");

                entity.HasOne(d => d.TauxTvaNavigation)
                    .WithMany(p => p._0105DetailFactureFournisseurs)
                    .HasForeignKey(d => d.TauxTva)
                    .HasConstraintName("FK_DetailFactureFournisseur_Tva");
            });

            modelBuilder.Entity<_0105FactureFournisseur>(entity =>
            {
                entity.HasKey(e => e.NumFacture)
                    .HasName("FactureFournisseur_PK_FactureAchat")
                    .IsClustered(false);

                entity.ToTable("0105_FactureFournisseur");

                entity.Property(e => e.NumFacture)
                    .HasMaxLength(50)
                    .HasColumnName("numFacture")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeFrs)
                    .HasMaxLength(50)
                    .HasColumnName("codeFrs")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeModeReg)
                    .HasMaxLength(50)
                    .HasColumnName("codeModeReg")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date");

                entity.Property(e => e.CreationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("creation_par");

                entity.Property(e => e.DateEcheance)
                    .HasColumnType("datetime")
                    .HasColumnName("dateEcheance");

                entity.Property(e => e.DateFacture)
                    .HasColumnType("datetime")
                    .HasColumnName("dateFacture");

                entity.Property(e => e.Datereglement)
                    .HasColumnType("datetime")
                    .HasColumnName("datereglement");

                entity.Property(e => e.Datesolder)
                    .HasColumnType("datetime")
                    .HasColumnName("datesolder");

                entity.Property(e => e.Datetransfert)
                    .HasColumnType("datetime")
                    .HasColumnName("datetransfert");

                entity.Property(e => e.Datevalidation)
                    .HasColumnType("datetime")
                    .HasColumnName("datevalidation");

                entity.Property(e => e.Etat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImprerssionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imprerssion_date");

                entity.Property(e => e.ImprerssionPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imprerssion_par");

                entity.Property(e => e.NumFactureFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("numFactureFournisseur")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumPiece)
                    .HasMaxLength(50)
                    .HasColumnName("numPiece");

                entity.Property(e => e.NumRegFrs)
                    .HasMaxLength(50)
                    .HasColumnName("numRegFrs");

                entity.Property(e => e.Observation)
                    .HasMaxLength(4000)
                    .HasColumnName("observation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PieceJointe)
                    .HasColumnType("image")
                    .HasColumnName("pieceJointe");

                entity.Property(e => e.Remise)
                    .HasColumnName("remise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoldeRegle).HasColumnName("soldeRegle");

                entity.Property(e => e.Soldee)
                    .HasColumnName("soldee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Temporaire).HasColumnName("temporaire");

                entity.Property(e => e.Transferer).HasColumnName("transferer");

                entity.Property(e => e.Validee)
                    .HasColumnName("validee")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeFrsNavigation)
                    .WithMany(p => p._0105FactureFournisseurs)
                    .HasForeignKey(d => d.CodeFrs)
                    .HasConstraintName("FK_FactureFournisseur_Fournisseur");

                entity.HasOne(d => d.CodeModeRegNavigation)
                    .WithMany(p => p._0105FactureFournisseurs)
                    .HasForeignKey(d => d.CodeModeReg)
                    .HasConstraintName("FK_FactureFournisseur_ModeReglement");
            });

            modelBuilder.Entity<_0105FactureFr>(entity =>
            {
                entity.ToTable("0105_FactureFrs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeFournisseur).HasMaxLength(50);

                entity.Property(e => e.DateEcheance)
                    .HasColumnType("date")
                    .HasColumnName("dateEcheance");

                entity.Property(e => e.DateFacture)
                    .HasColumnType("date")
                    .HasColumnName("dateFacture");

                entity.Property(e => e.Mnt).HasColumnName("mnt");

                entity.Property(e => e.MntCalcule).HasColumnName("mntCalcule");

                entity.Property(e => e.MntFacture).HasColumnName("mntFacture");

                entity.Property(e => e.NumFacture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numFacture");

                entity.Property(e => e.QtePayee).HasColumnName("qtePayee");

                entity.Property(e => e.QteRecu).HasColumnName("qteRecu");

                entity.Property(e => e.TypeFacture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typeFacture");

                entity.Property(e => e.Validee).HasColumnName("validee");

                entity.HasOne(d => d.CodeFournisseurNavigation)
                    .WithMany(p => p._0105FactureFrs)
                    .HasForeignKey(d => d.CodeFournisseur)
                    .HasConstraintName("FK_FactureFrs_0400_Fournisseur");
            });

            modelBuilder.Entity<_0106BonEntree>(entity =>
            {
                entity.ToTable("0106_BonEntree");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date");

                entity.Property(e => e.CreationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("creation_par");

                entity.Property(e => e.DateBe)
                    .HasColumnType("date")
                    .HasColumnName("dateBE");

                entity.Property(e => e.IdBt).HasColumnName("idBT");

                entity.Property(e => e.ImprerssionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imprerssion_date");

                entity.Property(e => e.ImpressionPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("impression_par");

                entity.Property(e => e.IsTransfert).HasColumnName("isTransfert");

                entity.Property(e => e.NumBe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBe");

                entity.Property(e => e.Observation)
                    .HasColumnType("text")
                    .HasColumnName("observation");

                entity.Property(e => e.ValidationDate)
                    .HasColumnType("date")
                    .HasColumnName("validation_date");

                entity.Property(e => e.ValidationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("validation_par");

                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.CodeMagasinNavigation)
                    .WithMany(p => p._0106BonEntrees)
                    .HasForeignKey(d => d.CodeMagasin)
                    .HasConstraintName("FK_0106_BonEntree_0400_Magasin");

                entity.HasOne(d => d.IdBtNavigation)
                    .WithMany(p => p._0106BonEntrees)
                    .HasForeignKey(d => d.IdBt)
                    .HasConstraintName("FK_0106_BonEntree_0107_BonTransfert");
            });

            modelBuilder.Entity<_0106DetailBonEntree>(entity =>
            {
                entity.ToTable("0106_DetailBonEntree");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeAffaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeAffaire");

                entity.Property(e => e.CodeArticle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeLot)
                    .HasMaxLength(50)
                    .HasColumnName("codeLot");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.CoutAchat).HasColumnName("coutAchat");

                entity.Property(e => e.DatePeremption)
                    .HasColumnType("date")
                    .HasColumnName("datePeremption");

                entity.Property(e => e.DernierPrix).HasColumnName("dernierPrix");

                entity.Property(e => e.DesignationArticle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("designationArticle");

                entity.Property(e => e.IdBonEntree).HasColumnName("idBonEntree");

                entity.Property(e => e.IdTypeMarchandise).HasColumnName("idTypeMarchandise");

                entity.Property(e => e.PrixAchat).HasColumnName("prixAchat");

                entity.Property(e => e.Qte).HasColumnName("qte");

                entity.Property(e => e.TypeLot).HasColumnName("typeLot");

                entity.HasOne(d => d.CodeArticleNavigation)
                    .WithMany(p => p._0106DetailBonEntrees)
                    .HasPrincipalKey(p => p.CodeArticle)
                    .HasForeignKey(d => d.CodeArticle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_0106_DetailBonEntree_0400_Article");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p._0106DetailBonEntrees)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_0106_DetailBonEntree_0000_Service");

                entity.HasOne(d => d.IdBonEntreeNavigation)
                    .WithMany(p => p._0106DetailBonEntrees)
                    .HasForeignKey(d => d.IdBonEntree)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_0106_DetailBonEntree_0106_BonEntree");

                entity.HasOne(d => d.IdTypeMarchandiseNavigation)
                    .WithMany(p => p._0106DetailBonEntrees)
                    .HasForeignKey(d => d.IdTypeMarchandise)
                    .HasConstraintName("FK_0106_DetailBonEntree_0102_TypeMarchandise");
            });

            modelBuilder.Entity<_0107BonTransfert>(entity =>
            {
                entity.ToTable("0107_BonTransfert");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeMagasinDestination)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasinDestination");

                entity.Property(e => e.CodeMagasinOrigine)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasinOrigine");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date");

                entity.Property(e => e.CreationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("creation_par");

                entity.Property(e => e.DateBt)
                    .HasColumnType("date")
                    .HasColumnName("dateBT");

                entity.Property(e => e.NumBt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBT");

                entity.Property(e => e.Observation)
                    .HasColumnType("text")
                    .HasColumnName("observation");

                entity.Property(e => e.ValidationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("validation_date");

                entity.Property(e => e.ValidationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("validation_par");

                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.CodeMagasinDestinationNavigation)
                    .WithMany(p => p._0107BonTransfertCodeMagasinDestinationNavigations)
                    .HasForeignKey(d => d.CodeMagasinDestination)
                    .HasConstraintName("FK_0107_BonTransfert_0400_Magasin1");

                entity.HasOne(d => d.CodeMagasinOrigineNavigation)
                    .WithMany(p => p._0107BonTransfertCodeMagasinOrigineNavigations)
                    .HasForeignKey(d => d.CodeMagasinOrigine)
                    .HasConstraintName("FK_0107_BonTransfert_0400_Magasin");
            });

            modelBuilder.Entity<_0107DetailBonTransfert>(entity =>
            {
                entity.ToTable("0107_DetailBonTransfert");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeLot)
                    .HasMaxLength(50)
                    .HasColumnName("codeLot");

                entity.Property(e => e.CodeMagasinDestination)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasinDestination");

                entity.Property(e => e.CodeMagasinOrigine)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasinOrigine");

                entity.Property(e => e.CodeServiceDestination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeServiceDestination");

                entity.Property(e => e.CodeServiceOrigine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeServiceOrigine");

                entity.Property(e => e.DatePeremption)
                    .HasColumnType("date")
                    .HasColumnName("datePeremption");

                entity.Property(e => e.DesignationArticle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("designationArticle");

                entity.Property(e => e.IdBt).HasColumnName("idBT");

                entity.Property(e => e.Qte).HasColumnName("qte");

                entity.Property(e => e.TypeLot).HasColumnName("typeLot");

                entity.HasOne(d => d.CodeMagasinDestinationNavigation)
                    .WithMany(p => p._0107DetailBonTransfertCodeMagasinDestinationNavigations)
                    .HasForeignKey(d => d.CodeMagasinDestination)
                    .HasConstraintName("FK_0107_DetailBonTransfert_0400_Magasin1");

                entity.HasOne(d => d.CodeMagasinOrigineNavigation)
                    .WithMany(p => p._0107DetailBonTransfertCodeMagasinOrigineNavigations)
                    .HasForeignKey(d => d.CodeMagasinOrigine)
                    .HasConstraintName("FK_0107_DetailBonTransfert_0400_Magasin");

                entity.HasOne(d => d.CodeServiceDestinationNavigation)
                    .WithMany(p => p._0107DetailBonTransfertCodeServiceDestinationNavigations)
                    .HasForeignKey(d => d.CodeServiceDestination)
                    .HasConstraintName("FK_0107_DetailBonTransfert_0000_Service1");

                entity.HasOne(d => d.CodeServiceOrigineNavigation)
                    .WithMany(p => p._0107DetailBonTransfertCodeServiceOrigineNavigations)
                    .HasForeignKey(d => d.CodeServiceOrigine)
                    .HasConstraintName("FK_0107_DetailBonTransfert_0000_Service");

                entity.HasOne(d => d.IdBtNavigation)
                    .WithMany(p => p._0107DetailBonTransferts)
                    .HasForeignKey(d => d.IdBt)
                    .HasConstraintName("FK_0107_DetailBonTransfert_0107_BonTransfert");
            });

            modelBuilder.Entity<_0108LotStock>(entity =>
            {
                entity.ToTable("0108_LotStock");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cmup).HasColumnName("CMUP");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("codeFournisseur");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.CoutAchat).HasColumnName("coutAchat");

                entity.Property(e => e.DateLot)
                    .HasColumnType("date")
                    .HasColumnName("dateLot");

                entity.Property(e => e.DatePeremption)
                    .HasColumnType("date")
                    .HasColumnName("datePeremption");

                entity.Property(e => e.IdDetailBonEntree).HasColumnName("idDetailBonEntree");

                entity.Property(e => e.IdDetailInventaire).HasColumnName("idDetailInventaire");

                entity.Property(e => e.IdDetailReception).HasColumnName("idDetailReception");

                entity.Property(e => e.IdTypeLot).HasColumnName("idTypeLot");

                entity.Property(e => e.NumBon)
                    .HasMaxLength(50)
                    .HasColumnName("numBon");

                entity.Property(e => e.Pu).HasColumnName("PU");

                entity.Property(e => e.QteLot).HasColumnName("qteLot");

                entity.Property(e => e.QteStockAjour).HasColumnName("qteStockAJour");

                entity.Property(e => e.RefLot)
                    .HasMaxLength(50)
                    .HasColumnName("refLot");

                entity.HasOne(d => d.CodeFournisseurNavigation)
                    .WithMany(p => p._0108LotStocks)
                    .HasForeignKey(d => d.CodeFournisseur)
                    .HasConstraintName("FK_0801_LotStock_0400_Fournisseur");

                entity.HasOne(d => d.CodeMagasinNavigation)
                    .WithMany(p => p._0108LotStocks)
                    .HasForeignKey(d => d.CodeMagasin)
                    .HasConstraintName("FK_0801_LotStock_0400_Magasin");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p._0108LotStocks)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_0108_LotStock_0000_Service");

                entity.HasOne(d => d.IdDetailBonEntreeNavigation)
                    .WithMany(p => p._0108LotStocks)
                    .HasForeignKey(d => d.IdDetailBonEntree)
                    .HasConstraintName("FK_0801_LotStock_0106_DetailBonEntree");

                entity.HasOne(d => d.IdDetailInventaireNavigation)
                    .WithMany(p => p._0108LotStocks)
                    .HasForeignKey(d => d.IdDetailInventaire)
                    .HasConstraintName("FK_0801_LotStock_0401_DetailInventaire");

                entity.HasOne(d => d.IdDetailReceptionNavigation)
                    .WithMany(p => p._0108LotStocks)
                    .HasForeignKey(d => d.IdDetailReception)
                    .HasConstraintName("FK_0801_LotStock_0104_DetailBonReception");

                entity.HasOne(d => d.IdTypeLotNavigation)
                    .WithMany(p => p._0108LotStocks)
                    .HasForeignKey(d => d.IdTypeLot)
                    .HasConstraintName("FK_0801_LotStock_0108_TypeLot");
            });

            modelBuilder.Entity<_0108MvtLotStock>(entity =>
            {
                entity.ToTable("0108_MvtLotStock");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.CoutAchat).HasColumnName("coutAchat");

                entity.Property(e => e.IdDetailBonEntree).HasColumnName("idDetailBonEntree");

                entity.Property(e => e.IdDetailBonEntreeOrigine).HasColumnName("idDetailBonEntree_origine");

                entity.Property(e => e.IdDetailBonReceptionOrigine).HasColumnName("idDetailBonReception_origine");

                entity.Property(e => e.IdDetailBonRetour).HasColumnName("idDetailBonRetour");

                entity.Property(e => e.IdDetailBonRetourOrigine).HasColumnName("idDetailBonRetour_origine");

                entity.Property(e => e.IdDetailBs).HasColumnName("idDetailBS");

                entity.Property(e => e.IdLotIventaireOrigine).HasColumnName("idLotIventaire_origine");

                entity.Property(e => e.IdTypeMvt).HasColumnName("idTypeMvt");

                entity.Property(e => e.IsLotOrigine).HasColumnName("isLot_Origine");

                entity.Property(e => e.Qte).HasColumnName("qte");

                entity.Property(e => e.TypeMvt)
                    .HasMaxLength(50)
                    .HasColumnName("typeMvt");

                entity.HasOne(d => d.CodeMagasinNavigation)
                    .WithMany(p => p._0108MvtLotStocks)
                    .HasForeignKey(d => d.CodeMagasin)
                    .HasConstraintName("FK_0108_MvtLotStock_0400_Magasin");

                entity.HasOne(d => d.IdDetailBonEntreeNavigation)
                    .WithMany(p => p._0108MvtLotStockIdDetailBonEntreeNavigations)
                    .HasForeignKey(d => d.IdDetailBonEntree)
                    .HasConstraintName("FK_0108_MvtLotStock_0106_DetailBonEntree1");

                entity.HasOne(d => d.IdDetailBonEntreeOrigineNavigation)
                    .WithMany(p => p._0108MvtLotStockIdDetailBonEntreeOrigineNavigations)
                    .HasForeignKey(d => d.IdDetailBonEntreeOrigine)
                    .HasConstraintName("FK_0108_MvtLotStock_0106_DetailBonEntree");

                entity.HasOne(d => d.IdDetailBonReceptionOrigineNavigation)
                    .WithMany(p => p._0108MvtLotStocks)
                    .HasForeignKey(d => d.IdDetailBonReceptionOrigine)
                    .HasConstraintName("FK_0108_MvtLotStock_0104_DetailBonReception");

                entity.HasOne(d => d.IdDetailBonRetourNavigation)
                    .WithMany(p => p._0108MvtLotStockIdDetailBonRetourNavigations)
                    .HasForeignKey(d => d.IdDetailBonRetour)
                    .HasConstraintName("FK_0108_MvtLotStock_0902_DetailBonRetour1");

                entity.HasOne(d => d.IdDetailBonRetourOrigineNavigation)
                    .WithMany(p => p._0108MvtLotStockIdDetailBonRetourOrigineNavigations)
                    .HasForeignKey(d => d.IdDetailBonRetourOrigine)
                    .HasConstraintName("FK_0108_MvtLotStock_0902_DetailBonRetour");

                entity.HasOne(d => d.IdDetailBsNavigation)
                    .WithMany(p => p._0108MvtLotStocks)
                    .HasForeignKey(d => d.IdDetailBs)
                    .HasConstraintName("FK_0108_MvtLotStock_0902_DetailBonSortieMagasin");

                entity.HasOne(d => d.IdTypeMvtNavigation)
                    .WithMany(p => p._0108MvtLotStocks)
                    .HasForeignKey(d => d.IdTypeMvt)
                    .HasConstraintName("FK_0108_MvtLotStock_0108_Type_Mvt");
            });

            modelBuilder.Entity<_0108TypeLot>(entity =>
            {
                entity.ToTable("0108_TypeLot");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .HasColumnName("designation");
            });

            modelBuilder.Entity<_0108TypeMvt>(entity =>
            {
                entity.ToTable("0108_Type_Mvt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Coefficient).HasColumnName("coefficient");

                entity.Property(e => e.TypeMvt)
                    .HasMaxLength(50)
                    .HasColumnName("typeMvt");
            });

            modelBuilder.Entity<_0109DetailFraisApproche>(entity =>
            {
                entity.ToTable("0109_DetailFraisApproche");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDetailRptAchat).HasColumnName("idDetailRpt_Achat");

                entity.Property(e => e.IdDetailRptFApproche).HasColumnName("idDetailRpt_F_Approche");

                entity.HasOne(d => d.IdDetailRptAchatNavigation)
                    .WithMany(p => p._0109DetailFraisApprocheIdDetailRptAchatNavigations)
                    .HasForeignKey(d => d.IdDetailRptAchat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_0109_DetailFraisApproche_0104_DetailBonReception");

                entity.HasOne(d => d.IdDetailRptFApprocheNavigation)
                    .WithMany(p => p._0109DetailFraisApprocheIdDetailRptFApprocheNavigations)
                    .HasForeignKey(d => d.IdDetailRptFApproche)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_0109_DetailFraisApproche_0104_DetailBonReception1");
            });

            modelBuilder.Entity<_0110BonLivraison>(entity =>
            {
                entity.ToTable("0110_BonLivraison");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeClient)
                    .HasMaxLength(50)
                    .HasColumnName("codeClient");

                entity.Property(e => e.DateBl)
                    .HasColumnType("date")
                    .HasColumnName("dateBL");

                entity.Property(e => e.Devise).HasMaxLength(50);

                entity.Property(e => e.IdDestination).HasColumnName("idDestination");

                entity.Property(e => e.IdDevise).HasColumnName("idDevise");

                entity.Property(e => e.IdFacture).HasColumnName("idFacture");

                entity.Property(e => e.MontantDh).HasColumnName("montantDH");

                entity.Property(e => e.NumBl)
                    .HasMaxLength(50)
                    .HasColumnName("numBL");

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .HasColumnName("observation");

                entity.Property(e => e.TauxDeChange).HasColumnName("tauxDeChange");

                entity.Property(e => e.TypeVente)
                    .HasMaxLength(50)
                    .HasColumnName("typeVente");

                entity.HasOne(d => d.CodeClientNavigation)
                    .WithMany(p => p._0110BonLivraisons)
                    .HasForeignKey(d => d.CodeClient)
                    .HasConstraintName("FK_0110_BonLivraison_Client");

                entity.HasOne(d => d.IdDestinationNavigation)
                    .WithMany(p => p._0110BonLivraisons)
                    .HasForeignKey(d => d.IdDestination)
                    .HasConstraintName("FK_0110_BonLivraison_0000_Ville1");

                entity.HasOne(d => d.IdDeviseNavigation)
                    .WithMany(p => p._0110BonLivraisons)
                    .HasForeignKey(d => d.IdDevise)
                    .HasConstraintName("FK_0110_BonLivraison_0200_Devise");

                entity.HasOne(d => d.IdFactureNavigation)
                    .WithMany(p => p._0110BonLivraisons)
                    .HasForeignKey(d => d.IdFacture)
                    .HasConstraintName("FK_0110_BonLivraison_0110_FactureComercial");
            });

            modelBuilder.Entity<_0110FactureComercial>(entity =>
            {
                entity.ToTable("0110_FactureComercial");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeClient)
                    .HasMaxLength(50)
                    .HasColumnName("codeClient");

                entity.Property(e => e.CodeModeReg)
                    .HasMaxLength(50)
                    .HasColumnName("codeModeReg");

                entity.Property(e => e.DateEcheance)
                    .HasColumnType("date")
                    .HasColumnName("dateEcheance");

                entity.Property(e => e.DateFac)
                    .HasColumnType("date")
                    .HasColumnName("dateFac");

                entity.Property(e => e.IdDevise).HasColumnName("idDevise");

                entity.Property(e => e.MontantDevise).HasColumnName("montantDevise");

                entity.Property(e => e.MontantDh).HasColumnName("montantDh");

                entity.Property(e => e.NumFac)
                    .HasMaxLength(50)
                    .HasColumnName("numFac");

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .HasColumnName("observation");

                entity.Property(e => e.TauxDeChange).HasColumnName("tauxDeChange");

                entity.HasOne(d => d.CodeClientNavigation)
                    .WithMany(p => p._0110FactureComercials)
                    .HasForeignKey(d => d.CodeClient)
                    .HasConstraintName("FK_0110_FactureComercial_Client");

                entity.HasOne(d => d.CodeModeRegNavigation)
                    .WithMany(p => p._0110FactureComercials)
                    .HasForeignKey(d => d.CodeModeReg)
                    .HasConstraintName("FK_0110_FactureComercial_1000_ModeReglement");

                entity.HasOne(d => d.IdDeviseNavigation)
                    .WithMany(p => p._0110FactureComercials)
                    .HasForeignKey(d => d.IdDevise)
                    .HasConstraintName("FK_0110_FactureComercial_0200_Devise");
            });

            modelBuilder.Entity<_0110LigneBonLivraison>(entity =>
            {
                entity.ToTable("0110_LigneBonLivraison");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.IdBonLivraison).HasColumnName("idBonLivraison");

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Prix).HasColumnName("prix");

                entity.Property(e => e.Qte).HasColumnName("qte");

                entity.HasOne(d => d.CodeArticleNavigation)
                    .WithMany(p => p._0110LigneBonLivraisons)
                    .HasPrincipalKey(p => p.CodeArticle)
                    .HasForeignKey(d => d.CodeArticle)
                    .HasConstraintName("FK_0110_LigneBonLivraison_0400_Article");

                entity.HasOne(d => d.CodeMagasinNavigation)
                    .WithMany(p => p._0110LigneBonLivraisons)
                    .HasForeignKey(d => d.CodeMagasin)
                    .HasConstraintName("FK_0110_LigneBonLivraison_0400_Magasin");

                entity.HasOne(d => d.IdBonLivraisonNavigation)
                    .WithMany(p => p._0110LigneBonLivraisons)
                    .HasForeignKey(d => d.IdBonLivraison)
                    .HasConstraintName("FK_0110_LigneBonLivraison_0110_BonLivraison");
            });

            modelBuilder.Entity<_0200Devise>(entity =>
            {
                entity.ToTable("0200_Devise");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .HasColumnName("designation");

                entity.Property(e => e.TauxDeChange).HasColumnName("tauxDeChange");
            });

            modelBuilder.Entity<_0400Article>(entity =>
            {
                entity.ToTable("0400_Article");

                entity.HasIndex(e => e.CodeArticle, "IX_0400_Article")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeArticle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.Designation).HasMaxLength(50);
            });

            modelBuilder.Entity<_0400ClasseArticle>(entity =>
            {
                entity.HasKey(e => e.IdClasseArticle)
                    .HasName("PK_ClasseArticles");

                entity.ToTable("0400_ClasseArticles");

                entity.Property(e => e.IdClasseArticle).HasColumnName("idClasseArticle");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .HasColumnName("designation");
            });

            modelBuilder.Entity<_0400FamilleArticle>(entity =>
            {
                entity.HasKey(e => e.CodeFamille)
                    .HasName("PK_FAM_ARTICLE");

                entity.ToTable("0400_FamilleArticle");

                entity.Property(e => e.CodeFamille)
                    .HasMaxLength(50)
                    .HasColumnName("codeFamille");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.IdGroupe).HasColumnName("idGroupe");

                entity.HasOne(d => d.IdGroupeNavigation)
                    .WithMany(p => p._0400FamilleArticles)
                    .HasForeignKey(d => d.IdGroupe)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FamilleArticle_GroupeFamilleArticle");
            });

            modelBuilder.Entity<_0400FamilleFournisseur>(entity =>
            {
                entity.HasKey(e => e.CodeFamille)
                    .HasName("PK_FamilleFournisseur");

                entity.ToTable("0400_FamilleFournisseur");

                entity.Property(e => e.CodeFamille)
                    .HasMaxLength(50)
                    .HasColumnName("codeFamille");

                entity.Property(e => e.Famille)
                    .HasMaxLength(50)
                    .HasColumnName("famille");
            });

            modelBuilder.Entity<_0400FamilleNatureArticle>(entity =>
            {
                entity.HasKey(e => e.IdFamilleNature)
                    .HasName("PK_FamilleNatureArticle");

                entity.ToTable("0400_FamilleNatureArticle");

                entity.Property(e => e.IdFamilleNature).HasColumnName("idFamilleNature");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .HasColumnName("designation");
            });

            modelBuilder.Entity<_0400Fournisseur>(entity =>
            {
                entity.HasKey(e => e.CodeFrs)
                    .HasName("PK_FRS");

                entity.ToTable("0400_Fournisseur");

                entity.Property(e => e.CodeFrs)
                    .HasMaxLength(50)
                    .HasColumnName("codeFrs");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(200)
                    .HasColumnName("adresse");

                entity.Property(e => e.Bloquer).HasColumnName("bloquer");

                entity.Property(e => e.CodeFamille)
                    .HasMaxLength(50)
                    .HasColumnName("codeFamille");

                entity.Property(e => e.CodeModeReg)
                    .HasMaxLength(50)
                    .HasColumnName("codeModeReg");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codePostal");

                entity.Property(e => e.DateAnouveau)
                    .HasColumnType("date")
                    .HasColumnName("dateAnouveau");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.Echeance).HasColumnName("echeance");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.FormeJuridique)
                    .HasMaxLength(50)
                    .HasColumnName("formeJuridique");

                entity.Property(e => e.IdAvance).HasColumnName("id_Avance");

                entity.Property(e => e.IdCompteAnalytique).HasColumnName("idCompteAnalytique");

                entity.Property(e => e.IdDevise).HasColumnName("idDevise");

                entity.Property(e => e.IdTypeFournisseur).HasColumnName("idTypeFournisseur");

                entity.Property(e => e.IdcompteGeneral).HasColumnName("idcompteGeneral");

                entity.Property(e => e.NumCompteTier)
                    .HasMaxLength(50)
                    .HasColumnName("numCompteTier");

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("site");

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tel");

                entity.Property(e => e.Ville)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ville");

                entity.HasOne(d => d.CodeFamilleNavigation)
                    .WithMany(p => p._0400Fournisseurs)
                    .HasForeignKey(d => d.CodeFamille)
                    .HasConstraintName("FK_Fournisseur_FamilleFournisseur1");

                entity.HasOne(d => d.CodeModeRegNavigation)
                    .WithMany(p => p._0400Fournisseurs)
                    .HasForeignKey(d => d.CodeModeReg)
                    .HasConstraintName("FK_Fournisseur_ModeReglement1");

                entity.HasOne(d => d.IdTypeFournisseurNavigation)
                    .WithMany(p => p._0400Fournisseurs)
                    .HasForeignKey(d => d.IdTypeFournisseur)
                    .HasConstraintName("FK_0400_Fournisseur_0401_TypeFournisseur");

                entity.HasOne(d => d.IdcompteGeneralNavigation)
                    .WithMany(p => p._0400Fournisseurs)
                    .HasForeignKey(d => d.IdcompteGeneral)
                    .HasConstraintName("FK_Fournisseur_Imputations_Comptables");
            });

            modelBuilder.Entity<_0400GroupeFamilleArticle>(entity =>
            {
                entity.ToTable("0400_GroupeFamilleArticle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .HasColumnName("designation");
            });

            modelBuilder.Entity<_0400Magasin>(entity =>
            {
                entity.HasKey(e => e.CodeMagasin)
                    .HasName("PK_Magasin");

                entity.ToTable("0400_Magasin");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.NonConforme).HasColumnName("nonConforme");
            });

            modelBuilder.Entity<_0400NatureArticle>(entity =>
            {
                entity.HasKey(e => e.Nature)
                    .HasName("PK_NatureArticle");

                entity.ToTable("0400_NatureArticle");

                entity.Property(e => e.Nature)
                    .HasMaxLength(50)
                    .HasColumnName("nature");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .HasColumnName("designation");

                entity.Property(e => e.IdFamilleNature).HasColumnName("idFamilleNature");

                entity.HasOne(d => d.IdFamilleNatureNavigation)
                    .WithMany(p => p._0400NatureArticles)
                    .HasForeignKey(d => d.IdFamilleNature)
                    .HasConstraintName("FK_NatureArticle_FamilleNatureArticle");
            });

            modelBuilder.Entity<_0401DetailInventaire>(entity =>
            {
                entity.HasKey(e => e.IdDetail)
                    .HasName("PK_DetailInventaire");

                entity.ToTable("0401_DetailInventaire");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.DernierPrixAchat).HasColumnName("Dernier_Prix_Achat");

                entity.Property(e => e.IdProduitBrut).HasColumnName("idProduitBrut");

                entity.Property(e => e.IdProduitFini).HasColumnName("idProduitFini");

                entity.Property(e => e.IdProduitSf).HasColumnName("idProduitSF");

                entity.Property(e => e.Idinventaire).HasColumnName("IDInventaire");

                entity.Property(e => e.Observation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrixMoy).HasColumnName("Prix_Moy");

                entity.Property(e => e.PrixVenteEstime).HasColumnName("prixVenteEstime");

                entity.Property(e => e.TypeArticle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typeArticle");

                entity.Property(e => e.TypeLot).HasColumnName("typeLot");

                entity.HasOne(d => d.IdinventaireNavigation)
                    .WithMany(p => p._0401DetailInventaires)
                    .HasForeignKey(d => d.Idinventaire)
                    .HasConstraintName("FK_DetailInventaire_Inventaires");
            });

            modelBuilder.Entity<_0401Inventaire>(entity =>
            {
                entity.HasKey(e => e.Idinventaire)
                    .HasName("PK_Inventaires");

                entity.ToTable("0401_Inventaires");

                entity.Property(e => e.Idinventaire).HasColumnName("IDInventaire");

                entity.Property(e => e.CodeInventaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeInventaire");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.DateInv).HasColumnType("datetime");

                entity.Property(e => e.IdPoste).HasColumnName("idPoste");

                entity.Property(e => e.Justif)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeMagasinNavigation)
                    .WithMany(p => p._0401Inventaires)
                    .HasForeignKey(d => d.CodeMagasin)
                    .HasConstraintName("FK_Inventaires_Magasin");
            });

            modelBuilder.Entity<_0401TypeFournisseur>(entity =>
            {
                entity.ToTable("0401_TypeFournisseur");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designation");
            });

            modelBuilder.Entity<_0500CategorieIputation>(entity =>
            {
                entity.HasKey(e => e.IdCategorie)
                    .HasName("PK_Poste_Comptable");

                entity.ToTable("0500_CategorieIputation");

                entity.Property(e => e.Compte).HasMaxLength(50);

                entity.Property(e => e.Intitule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRubriqueGNavigation)
                    .WithMany(p => p._0500CategorieIputations)
                    .HasForeignKey(d => d.IdRubriqueG)
                    .HasConstraintName("FK_Poste_Comptable_Rubrique_Charges");
            });

            modelBuilder.Entity<_0500ImputationsComptable>(entity =>
            {
                entity.HasKey(e => e.IdCompteComtabiliteG)
                    .HasName("PK_Imputations_Comptables");

                entity.ToTable("0500_Imputations_Comptables");

                entity.Property(e => e.IdCompteComtabiliteG).HasColumnName("idCompteComtabiliteG");

                entity.Property(e => e.IdPlanComptable).HasColumnName("idPlanComptable");

                entity.Property(e => e.Intitule).HasMaxLength(50);

                entity.Property(e => e.Ncompte).HasColumnName("NCompte");

                entity.HasOne(d => d.IdCategorieNavigation)
                    .WithMany(p => p._0500ImputationsComptables)
                    .HasForeignKey(d => d.IdCategorie)
                    .HasConstraintName("FK_0500_Imputations_Comptables_0500_CategorieIputation");

                entity.HasOne(d => d.IdPlanComptableNavigation)
                    .WithMany(p => p._0500ImputationsComptables)
                    .HasForeignKey(d => d.IdPlanComptable)
                    .HasConstraintName("FK_Imputations_Comptables_PlanComptable");
            });

            modelBuilder.Entity<_0500JournauxComptable>(entity =>
            {
                entity.ToTable("0500_JournauxComptable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .HasColumnName("designation");
            });

            modelBuilder.Entity<_0500PlanComptable>(entity =>
            {
                entity.ToTable("0500_PlanComptable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.IdCategorieImputation).HasColumnName("idCategorieImputation");

                entity.Property(e => e.Intitule)
                    .HasMaxLength(150)
                    .HasColumnName("intitule");

                entity.HasOne(d => d.IdCategorieImputationNavigation)
                    .WithMany(p => p._0500PlanComptables)
                    .HasForeignKey(d => d.IdCategorieImputation)
                    .HasConstraintName("FK_PlanComptable_CategorieIputation");
            });

            modelBuilder.Entity<_0500RubriqueImputationG>(entity =>
            {
                entity.HasKey(e => e.IdRubriqueG)
                    .HasName("PK_Rubrique_Charges");

                entity.ToTable("0500_Rubrique_ImputationG");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Intitule)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_0902BonRetour>(entity =>
            {
                entity.ToTable("0902_BonRetour");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date");

                entity.Property(e => e.CreationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("creation_par");

                entity.Property(e => e.DateBonAu)
                    .HasColumnType("datetime")
                    .HasColumnName("dateBonAu");

                entity.Property(e => e.DateBonDu)
                    .HasColumnType("datetime")
                    .HasColumnName("dateBonDu");

                entity.Property(e => e.DateRetour)
                    .HasColumnType("datetime")
                    .HasColumnName("dateRetour");

                entity.Property(e => e.ImprerssionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imprerssion_date");

                entity.Property(e => e.ImprerssionPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imprerssion_par");

                entity.Property(e => e.NumBl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBL");

                entity.Property(e => e.NumBon)
                    .HasMaxLength(50)
                    .HasColumnName("numBon");

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .HasColumnName("observation");

                entity.Property(e => e.TypeBon)
                    .HasMaxLength(50)
                    .HasColumnName("typeBon");

                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.NumBlNavigation)
                    .WithMany(p => p._0902BonRetours)
                    .HasForeignKey(d => d.NumBl)
                    .HasConstraintName("FK_0902_BonRetour_0902_BonSortieMagasin");
            });

            modelBuilder.Entity<_0902BonSortieMagasin>(entity =>
            {
                entity.HasKey(e => e.NumBl)
                    .HasName("PK_BS");

                entity.ToTable("0902_BonSortieMagasin");

                entity.Property(e => e.NumBl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBL");

                entity.Property(e => e.CodeClient)
                    .HasMaxLength(50)
                    .HasColumnName("codeClient");

                entity.Property(e => e.CodeMagasin)
                    .HasMaxLength(50)
                    .HasColumnName("codeMagasin");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date");

                entity.Property(e => e.CreationPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("creation_par");

                entity.Property(e => e.DateBl)
                    .HasColumnType("datetime")
                    .HasColumnName("dateBL");

                entity.Property(e => e.IdBt).HasColumnName("idBT");

                entity.Property(e => e.ImprerssionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imprerssion_date");

                entity.Property(e => e.ImprerssionPar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imprerssion_par");

                entity.Property(e => e.IsTransfert).HasColumnName("isTransfert");

                entity.Property(e => e.NumBonCarnet)
                    .HasMaxLength(50)
                    .HasColumnName("numBonCarnet");

                entity.Property(e => e.Observation).HasColumnName("observation");

                entity.Property(e => e.Remise).HasColumnName("remise");

                entity.Property(e => e.TypeBs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typeBS");

                entity.Property(e => e.TypeConsommation).HasColumnName("typeConsommation");

                entity.Property(e => e.TypeProduction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSortie)
                    .HasMaxLength(50)
                    .HasColumnName("typeSortie");

                entity.Property(e => e.Valider).HasColumnName("valider");

                entity.HasOne(d => d.CodeClientNavigation)
                    .WithMany(p => p._0902BonSortieMagasins)
                    .HasForeignKey(d => d.CodeClient)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BonLivraisonClient_Client");

                entity.HasOne(d => d.CodeMagasinNavigation)
                    .WithMany(p => p._0902BonSortieMagasins)
                    .HasForeignKey(d => d.CodeMagasin)
                    .HasConstraintName("FK_BonLivraisonClient_Magasin");

                entity.HasOne(d => d.IdBtNavigation)
                    .WithMany(p => p._0902BonSortieMagasins)
                    .HasForeignKey(d => d.IdBt)
                    .HasConstraintName("FK_0902_BonSortieMagasin_0107_BonTransfert");
            });

            modelBuilder.Entity<_0902DetailBonRetour>(entity =>
            {
                entity.ToTable("0902_DetailBonRetour");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeAffaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeAffaire");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeLot)
                    .HasMaxLength(50)
                    .HasColumnName("codeLot");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.DatePeremption)
                    .HasColumnType("date")
                    .HasColumnName("datePeremption");

                entity.Property(e => e.IdBonRetour).HasColumnName("idBonRetour");

                entity.Property(e => e.IdCompteAnalytique).HasColumnName("idCompteAnalytique");

                entity.Property(e => e.IdCompteComtabiliteG).HasColumnName("idCompteComtabiliteG");

                entity.Property(e => e.Prix).HasColumnName("prix");

                entity.Property(e => e.Qte).HasColumnName("qte");

                entity.Property(e => e.TypeLot)
                    .HasMaxLength(50)
                    .HasColumnName("typeLot");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p._0902DetailBonRetours)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_0902_DetailBonRetour_0000_Service");

                entity.HasOne(d => d.IdBonRetourNavigation)
                    .WithMany(p => p._0902DetailBonRetours)
                    .HasForeignKey(d => d.IdBonRetour)
                    .HasConstraintName("FK_0902_DetailBonRetour_0902_BonRetour");

                entity.HasOne(d => d.IdCompteComtabiliteGNavigation)
                    .WithMany(p => p._0902DetailBonRetours)
                    .HasForeignKey(d => d.IdCompteComtabiliteG)
                    .HasConstraintName("FK_0902_DetailBonRetour_0500_Imputations_Comptables");
            });

            modelBuilder.Entity<_0902DetailBonSortieMagasin>(entity =>
            {
                entity.HasKey(e => e.NumDbl)
                    .HasName("PK_DetailBonLivraison");

                entity.ToTable("0902_DetailBonSortieMagasin");

                entity.Property(e => e.NumDbl).HasColumnName("numDBL");

                entity.Property(e => e.CodeAffaire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeAffaire");

                entity.Property(e => e.CodeArticle)
                    .HasMaxLength(50)
                    .HasColumnName("codeArticle");

                entity.Property(e => e.CodeService)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codeService");

                entity.Property(e => e.DernierPrix).HasColumnName("dernierPrix");

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .HasColumnName("designation");

                entity.Property(e => e.IdCompteAnalytique).HasColumnName("idCompteAnalytique");

                entity.Property(e => e.IdCompteComtabiliteG).HasColumnName("idCompteComtabiliteG");

                entity.Property(e => e.NumBl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numBL");

                entity.Property(e => e.Observation)
                    .HasColumnType("text")
                    .HasColumnName("observation");

                entity.Property(e => e.Prix).HasColumnName("prix");

                entity.Property(e => e.PrixMoyenne).HasColumnName("prixMoyenne");

                entity.Property(e => e.Qte).HasColumnName("qte");

                entity.Property(e => e.Remise).HasColumnName("remise");

                entity.Property(e => e.UniteAchat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uniteAchat");

                entity.HasOne(d => d.CodeServiceNavigation)
                    .WithMany(p => p._0902DetailBonSortieMagasins)
                    .HasForeignKey(d => d.CodeService)
                    .HasConstraintName("FK_DetailBonLivraison_Service");

                entity.HasOne(d => d.IdCompteComtabiliteGNavigation)
                    .WithMany(p => p._0902DetailBonSortieMagasins)
                    .HasForeignKey(d => d.IdCompteComtabiliteG)
                    .HasConstraintName("FK_DetailBonLivraisonClient_Imputations_Comptables");

                entity.HasOne(d => d.NumBlNavigation)
                    .WithMany(p => p._0902DetailBonSortieMagasins)
                    .HasForeignKey(d => d.NumBl)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_D_BS_BS");
            });

            modelBuilder.Entity<_1000ModeReglement>(entity =>
            {
                entity.HasKey(e => e.CodeModeReg)
                    .HasName("PK_MODE_REG");

                entity.ToTable("1000_ModeReglement");

                entity.Property(e => e.CodeModeReg)
                    .HasMaxLength(50)
                    .HasColumnName("codeModeReg");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designation");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
