using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0902DetailBonRetour
    {
        public _0902DetailBonRetour()
        {
            _0108MvtLotStockIdDetailBonRetourNavigations = new HashSet<_0108MvtLotStock>();
            _0108MvtLotStockIdDetailBonRetourOrigineNavigations = new HashSet<_0108MvtLotStock>();
        }

        public int Id { get; set; }
        public int? IdBonRetour { get; set; }
        public string CodeArticle { get; set; }
        public string CodeAffaire { get; set; }
        public double? Qte { get; set; }
        public int? IdCompteAnalytique { get; set; }
        public int? IdCompteComtabiliteG { get; set; }
        public double? Prix { get; set; }
        public string CodeService { get; set; }
        public DateTime? DatePeremption { get; set; }
        public string CodeLot { get; set; }
        public string TypeLot { get; set; }

        public virtual _0000Service CodeServiceNavigation { get; set; }
        public virtual _0902BonRetour IdBonRetourNavigation { get; set; }
        public virtual _0500ImputationsComptable IdCompteComtabiliteGNavigation { get; set; }
        public virtual ICollection<_0108MvtLotStock> _0108MvtLotStockIdDetailBonRetourNavigations { get; set; }
        public virtual ICollection<_0108MvtLotStock> _0108MvtLotStockIdDetailBonRetourOrigineNavigations { get; set; }
    }
}
