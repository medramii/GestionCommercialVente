using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0104DetailBonReception
    {
        public _0104DetailBonReception()
        {
            _0105DetailFactureFournisseurs = new HashSet<_0105DetailFactureFournisseur>();
            _0108LotStocks = new HashSet<_0108LotStock>();
            _0108MvtLotStocks = new HashSet<_0108MvtLotStock>();
            _0109DetailFraisApprocheIdDetailRptAchatNavigations = new HashSet<_0109DetailFraisApproche>();
            _0109DetailFraisApprocheIdDetailRptFApprocheNavigations = new HashSet<_0109DetailFraisApproche>();
        }

        public string CodeAffaire { get; set; }
        public int NumDbr { get; set; }
        public string NumBr { get; set; }
        public string CodeNatureAchat { get; set; }
        public float? PrixAchat { get; set; }
        public float? QteLivree { get; set; }
        public float? Remise { get; set; }
        public string NumCmd { get; set; }
        public string CodeService { get; set; }
        public float? QteFacturee { get; set; }
        public bool? Etat { get; set; }
        public float? TauxTva { get; set; }
        public string Observation { get; set; }
        public string CodeArticle { get; set; }
        public int? IdCompteComtabiliteG { get; set; }
        public int? IdCompteAnalytique { get; set; }
        public float? FraisApproche { get; set; }
        public float? CoutAchat { get; set; }
        public string Designation { get; set; }
        public bool? TypeLot { get; set; }
        public string CodeLot { get; set; }
        public double? QteSortie { get; set; }
        public double? QteRestante { get; set; }
        public bool? Inventorie { get; set; }
        public int? IdDevise { get; set; }
        public double? TauxDeChange { get; set; }
        public double? PrixHt { get; set; }
        public int? IdTypeMarchandise { get; set; }
        public DateTime? DatePeremption { get; set; }
        public bool? IsFraisApproche { get; set; }
        public int? IdQualiteReception { get; set; }

        public virtual _0000Service CodeServiceNavigation { get; set; }
        public virtual _0500ImputationsComptable IdCompteComtabiliteGNavigation { get; set; }
        public virtual _0104QualiteReception IdQualiteReceptionNavigation { get; set; }
        public virtual _0102TypeMarchandise IdTypeMarchandiseNavigation { get; set; }
        public virtual _0104BonReception NumBrNavigation { get; set; }
        public virtual _0000Tva TauxTvaNavigation { get; set; }
        public virtual ICollection<_0105DetailFactureFournisseur> _0105DetailFactureFournisseurs { get; set; }
        public virtual ICollection<_0108LotStock> _0108LotStocks { get; set; }
        public virtual ICollection<_0108MvtLotStock> _0108MvtLotStocks { get; set; }
        public virtual ICollection<_0109DetailFraisApproche> _0109DetailFraisApprocheIdDetailRptAchatNavigations { get; set; }
        public virtual ICollection<_0109DetailFraisApproche> _0109DetailFraisApprocheIdDetailRptFApprocheNavigations { get; set; }
    }
}
