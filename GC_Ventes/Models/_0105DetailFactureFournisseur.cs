using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0105DetailFactureFournisseur
    {
        public int NumDetailFactureFournisseur { get; set; }
        public string NumBr { get; set; }
        public string NumFacture { get; set; }
        public string CodeArticle { get; set; }
        public string CodeAffaire { get; set; }
        public string CodeNatureAchat { get; set; }
        public float? QteLivree { get; set; }
        public float? PrixAchat { get; set; }
        public float? Remise { get; set; }
        public float? TauxTva { get; set; }
        public bool? Etat { get; set; }
        public float? PrixAchatR { get; set; }
        public string Observation { get; set; }
        public int? IdCompteComtabiliteG { get; set; }
        public int? IdCompteAnalytique { get; set; }
        public int? NumDbr { get; set; }
        public string Designation { get; set; }
        public int? IdDevise { get; set; }
        public double? PrixHt { get; set; }
        public double? TauxDeChange { get; set; }

        public virtual _0500ImputationsComptable IdCompteComtabiliteGNavigation { get; set; }
        public virtual _0104DetailBonReception NumDbrNavigation { get; set; }
        public virtual _0105FactureFournisseur NumFactureNavigation { get; set; }
        public virtual _0000Tva TauxTvaNavigation { get; set; }
    }
}
