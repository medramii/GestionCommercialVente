using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0902DetailBonSortieMagasin
    {
        public _0902DetailBonSortieMagasin()
        {
            _0108MvtLotStocks = new HashSet<_0108MvtLotStock>();
        }

        public int NumDbl { get; set; }
        public string NumBl { get; set; }
        public string CodeArticle { get; set; }
        public string CodeAffaire { get; set; }
        public string CodeService { get; set; }
        public float Qte { get; set; }
        public float Prix { get; set; }
        public float Remise { get; set; }
        public string Observation { get; set; }
        public float PrixMoyenne { get; set; }
        public float DernierPrix { get; set; }
        public int? IdCompteAnalytique { get; set; }
        public int? IdCompteComtabiliteG { get; set; }
        public string Designation { get; set; }
        public string UniteAchat { get; set; }

        public virtual _0000Service CodeServiceNavigation { get; set; }
        public virtual _0500ImputationsComptable IdCompteComtabiliteGNavigation { get; set; }
        public virtual _0902BonSortieMagasin NumBlNavigation { get; set; }
        public virtual ICollection<_0108MvtLotStock> _0108MvtLotStocks { get; set; }
    }
}
