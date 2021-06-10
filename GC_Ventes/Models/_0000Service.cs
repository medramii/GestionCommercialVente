using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0000Service
    {
        public _0000Service()
        {
            _0102DemandeAchats = new HashSet<_0102DemandeAchat>();
            _0103BonCommandeAchats = new HashSet<_0103BonCommandeAchat>();
            _0103DetailBonCommandeAchats = new HashSet<_0103DetailBonCommandeAchat>();
            _0104DetailBonReceptions = new HashSet<_0104DetailBonReception>();
            _0106DetailBonEntrees = new HashSet<_0106DetailBonEntree>();
            _0107DetailBonTransfertCodeServiceDestinationNavigations = new HashSet<_0107DetailBonTransfert>();
            _0107DetailBonTransfertCodeServiceOrigineNavigations = new HashSet<_0107DetailBonTransfert>();
            _0108LotStocks = new HashSet<_0108LotStock>();
            _0902DetailBonRetours = new HashSet<_0902DetailBonRetour>();
            _0902DetailBonSortieMagasins = new HashSet<_0902DetailBonSortieMagasin>();
        }

        public string CodeService { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<_0102DemandeAchat> _0102DemandeAchats { get; set; }
        public virtual ICollection<_0103BonCommandeAchat> _0103BonCommandeAchats { get; set; }
        public virtual ICollection<_0103DetailBonCommandeAchat> _0103DetailBonCommandeAchats { get; set; }
        public virtual ICollection<_0104DetailBonReception> _0104DetailBonReceptions { get; set; }
        public virtual ICollection<_0106DetailBonEntree> _0106DetailBonEntrees { get; set; }
        public virtual ICollection<_0107DetailBonTransfert> _0107DetailBonTransfertCodeServiceDestinationNavigations { get; set; }
        public virtual ICollection<_0107DetailBonTransfert> _0107DetailBonTransfertCodeServiceOrigineNavigations { get; set; }
        public virtual ICollection<_0108LotStock> _0108LotStocks { get; set; }
        public virtual ICollection<_0902DetailBonRetour> _0902DetailBonRetours { get; set; }
        public virtual ICollection<_0902DetailBonSortieMagasin> _0902DetailBonSortieMagasins { get; set; }
    }
}
