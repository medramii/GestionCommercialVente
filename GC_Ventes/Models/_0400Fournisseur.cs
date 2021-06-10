using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400Fournisseur
    {
        public _0400Fournisseur()
        {
            _0102DemandeAchats = new HashSet<_0102DemandeAchat>();
            _0102Devis = new HashSet<_0102Devi>();
            _0103BonCommandeAchats = new HashSet<_0103BonCommandeAchat>();
            _0104BonReceptions = new HashSet<_0104BonReception>();
            _0105FactureFournisseurs = new HashSet<_0105FactureFournisseur>();
            _0105FactureFrs = new HashSet<_0105FactureFr>();
            _0108LotStocks = new HashSet<_0108LotStock>();
        }

        public string CodeFrs { get; set; }
        public string Designation { get; set; }
        public int? IdDevise { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string CodeFamille { get; set; }
        public int? IdcompteGeneral { get; set; }
        public int? IdCompteAnalytique { get; set; }
        public bool? Bloquer { get; set; }
        public double? Anouveau { get; set; }
        public DateTime? DateAnouveau { get; set; }
        public string CodeModeReg { get; set; }
        public string FormeJuridique { get; set; }
        public int? IdAvance { get; set; }
        public string NumCompteTier { get; set; }
        public int? IdTypeFournisseur { get; set; }
        public int? Echeance { get; set; }

        public virtual _0400FamilleFournisseur CodeFamilleNavigation { get; set; }
        public virtual _1000ModeReglement CodeModeRegNavigation { get; set; }
        public virtual _0401TypeFournisseur IdTypeFournisseurNavigation { get; set; }
        public virtual _0500ImputationsComptable IdcompteGeneralNavigation { get; set; }
        public virtual ICollection<_0102DemandeAchat> _0102DemandeAchats { get; set; }
        public virtual ICollection<_0102Devi> _0102Devis { get; set; }
        public virtual ICollection<_0103BonCommandeAchat> _0103BonCommandeAchats { get; set; }
        public virtual ICollection<_0104BonReception> _0104BonReceptions { get; set; }
        public virtual ICollection<_0105FactureFournisseur> _0105FactureFournisseurs { get; set; }
        public virtual ICollection<_0105FactureFr> _0105FactureFrs { get; set; }
        public virtual ICollection<_0108LotStock> _0108LotStocks { get; set; }
    }
}
