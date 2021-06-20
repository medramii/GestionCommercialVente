using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0106DetailBonEntree
    {
        public _0106DetailBonEntree()
        {
            _0108LotStocks = new HashSet<_0108LotStock>();
            _0108MvtLotStockIdDetailBonEntreeNavigations = new HashSet<_0108MvtLotStock>();
            _0108MvtLotStockIdDetailBonEntreeOrigineNavigations = new HashSet<_0108MvtLotStock>();
        }

        public int Id { get; set; }
        public int IdBonEntree { get; set; }
        public string CodeArticle { get; set; }
        public double? Qte { get; set; }
        public double? CoutAchat { get; set; }
        public int? IdTypeMarchandise { get; set; }
        public string CodeAffaire { get; set; }
        public string CodeService { get; set; }
        public string DesignationArticle { get; set; }
        public double? DernierPrix { get; set; }
        public double? PrixAchat { get; set; }
        public DateTime? DatePeremption { get; set; }
        public string CodeLot { get; set; }
        public bool? TypeLot { get; set; }

        public virtual _0400Article CodeArticleNavigation { get; set; }
        public virtual _0000Service CodeServiceNavigation { get; set; }
        public virtual _0106BonEntree IdBonEntreeNavigation { get; set; }
        public virtual _0102TypeMarchandise IdTypeMarchandiseNavigation { get; set; }
        public virtual ICollection<_0108LotStock> _0108LotStocks { get; set; }
        public virtual ICollection<_0108MvtLotStock> _0108MvtLotStockIdDetailBonEntreeNavigations { get; set; }
        public virtual ICollection<_0108MvtLotStock> _0108MvtLotStockIdDetailBonEntreeOrigineNavigations { get; set; }
    }
}
