using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0103DetailBonCommandeAchat
    {
        public int NumDetailComande { get; set; }
        public string NumComande { get; set; }
        public string CodeArticle { get; set; }
        public string CodeAffaire { get; set; }
        public float? QteComandee { get; set; }
        public float? QteLivree { get; set; }
        public string CodeNatureAchat { get; set; }
        public float? PrixAchat { get; set; }
        public float? Remise { get; set; }
        public string NumDemande { get; set; }
        public string Observation { get; set; }
        public float? TauxTva { get; set; }
        public int? IdCompteComtabiliteG { get; set; }
        public int? IdCompteAnalytique { get; set; }
        public string CodeService { get; set; }
        public string Designation { get; set; }
        public int? IdDevise { get; set; }
        public double? TauxDeChange { get; set; }
        public double? PrixHt { get; set; }
        public int? IdTypeMarchandise { get; set; }
        public int? IdDevis { get; set; }

        public virtual _0000Service CodeServiceNavigation { get; set; }
        public virtual _0500ImputationsComptable IdCompteComtabiliteGNavigation { get; set; }
        public virtual _0102Devi IdDevisNavigation { get; set; }
        public virtual _0102TypeMarchandise IdTypeMarchandiseNavigation { get; set; }
        public virtual _0103BonCommandeAchat NumComandeNavigation { get; set; }
        public virtual _0102DemandeAchat NumDemandeNavigation { get; set; }
        public virtual _0000Tva TauxTvaNavigation { get; set; }
    }
}
