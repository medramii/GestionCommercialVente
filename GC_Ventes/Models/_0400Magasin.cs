using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400Magasin
    {
        public _0400Magasin()
        {
            _0104BonReceptions = new HashSet<_0104BonReception>();
            _0106BonEntrees = new HashSet<_0106BonEntree>();
            _0107BonTransfertCodeMagasinDestinationNavigations = new HashSet<_0107BonTransfert>();
            _0107BonTransfertCodeMagasinOrigineNavigations = new HashSet<_0107BonTransfert>();
            _0107DetailBonTransfertCodeMagasinDestinationNavigations = new HashSet<_0107DetailBonTransfert>();
            _0107DetailBonTransfertCodeMagasinOrigineNavigations = new HashSet<_0107DetailBonTransfert>();
            _0108LotStocks = new HashSet<_0108LotStock>();
            _0108MvtLotStocks = new HashSet<_0108MvtLotStock>();
            _0110LigneBonLivraisons = new HashSet<_0110LigneBonLivraison>();
            _0401Inventaires = new HashSet<_0401Inventaire>();
            _0902BonSortieMagasins = new HashSet<_0902BonSortieMagasin>();
        }

        public string CodeMagasin { get; set; }
        public string Designation { get; set; }
        public bool? NonConforme { get; set; }

        public virtual ICollection<_0104BonReception> _0104BonReceptions { get; set; }
        public virtual ICollection<_0106BonEntree> _0106BonEntrees { get; set; }
        public virtual ICollection<_0107BonTransfert> _0107BonTransfertCodeMagasinDestinationNavigations { get; set; }
        public virtual ICollection<_0107BonTransfert> _0107BonTransfertCodeMagasinOrigineNavigations { get; set; }
        public virtual ICollection<_0107DetailBonTransfert> _0107DetailBonTransfertCodeMagasinDestinationNavigations { get; set; }
        public virtual ICollection<_0107DetailBonTransfert> _0107DetailBonTransfertCodeMagasinOrigineNavigations { get; set; }
        public virtual ICollection<_0108LotStock> _0108LotStocks { get; set; }
        public virtual ICollection<_0108MvtLotStock> _0108MvtLotStocks { get; set; }
        public virtual ICollection<_0110LigneBonLivraison> _0110LigneBonLivraisons { get; set; }
        public virtual ICollection<_0401Inventaire> _0401Inventaires { get; set; }
        public virtual ICollection<_0902BonSortieMagasin> _0902BonSortieMagasins { get; set; }
    }
}
