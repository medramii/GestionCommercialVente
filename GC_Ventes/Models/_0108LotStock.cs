using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0108LotStock
    {
        public int Id { get; set; }
        public string RefLot { get; set; }
        public string NumBon { get; set; }
        public int? IdTypeLot { get; set; }
        public int? IdDetailReception { get; set; }
        public int? IdDetailInventaire { get; set; }
        public int? IdDetailBonEntree { get; set; }
        public DateTime? DateLot { get; set; }
        public double? QteLot { get; set; }
        public double? QteStockAjour { get; set; }
        public string CodeFournisseur { get; set; }
        public string CodeArticle { get; set; }
        public double? Pu { get; set; }
        public double? Cmup { get; set; }
        public string CodeMagasin { get; set; }
        public DateTime? DatePeremption { get; set; }
        public string CodeService { get; set; }
        public double? CoutAchat { get; set; }

        public virtual _0400Fournisseur CodeFournisseurNavigation { get; set; }
        public virtual _0400Magasin CodeMagasinNavigation { get; set; }
        public virtual _0000Service CodeServiceNavigation { get; set; }
        public virtual _0106DetailBonEntree IdDetailBonEntreeNavigation { get; set; }
        public virtual _0401DetailInventaire IdDetailInventaireNavigation { get; set; }
        public virtual _0104DetailBonReception IdDetailReceptionNavigation { get; set; }
        public virtual _0108TypeLot IdTypeLotNavigation { get; set; }
    }
}
