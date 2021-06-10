using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0107DetailBonTransfert
    {
        public int Id { get; set; }
        public int? IdBt { get; set; }
        public string CodeArticle { get; set; }
        public string CodeMagasinOrigine { get; set; }
        public string CodeMagasinDestination { get; set; }
        public string CodeServiceOrigine { get; set; }
        public string CodeServiceDestination { get; set; }
        public double? Qte { get; set; }
        public string DesignationArticle { get; set; }
        public DateTime? DatePeremption { get; set; }
        public string CodeLot { get; set; }
        public bool? TypeLot { get; set; }

        public virtual _0400Magasin CodeMagasinDestinationNavigation { get; set; }
        public virtual _0400Magasin CodeMagasinOrigineNavigation { get; set; }
        public virtual _0000Service CodeServiceDestinationNavigation { get; set; }
        public virtual _0000Service CodeServiceOrigineNavigation { get; set; }
        public virtual _0107BonTransfert IdBtNavigation { get; set; }
    }
}
