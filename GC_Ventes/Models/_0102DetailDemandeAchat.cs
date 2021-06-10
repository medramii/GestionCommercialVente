using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0102DetailDemandeAchat
    {
        public int NumDetailDemande { get; set; }
        public string NumDemande { get; set; }
        public string CodeArticle { get; set; }
        public string CodeAffaire { get; set; }
        public float? QteDemandee { get; set; }
        public float? QteCommandee { get; set; }
        public string CodeNatureAchat { get; set; }
        public string Observation { get; set; }
        public bool? Etat { get; set; }
        public int? IdCompteComtabiliteG { get; set; }
        public int? IdCompteAnalytique { get; set; }
        public string Designation { get; set; }
        public double? QteStock { get; set; }
        public int? IdTypeMarchandise { get; set; }

        public virtual _0500ImputationsComptable IdCompteComtabiliteGNavigation { get; set; }
        public virtual _0102TypeMarchandise IdTypeMarchandiseNavigation { get; set; }
        public virtual _0102DemandeAchat NumDemandeNavigation { get; set; }
    }
}
