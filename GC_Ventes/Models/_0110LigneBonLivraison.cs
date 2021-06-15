using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0110LigneBonLivraison
    {
        public int Id { get; set; }
        public int? IdBonLivraison { get; set; }
        public string CodeArticle { get; set; }
        public double? Qte { get; set; }
        public double? Prix { get; set; }
        public double? Montant { get; set; }
        public string CodeMagasin { get; set; }

        public virtual _0400Article CodeArticleNavigation { get; set; }
        public virtual _0400Magasin CodeMagasinNavigation { get; set; }
        public virtual _0110BonLivraison IdBonLivraisonNavigation { get; set; }
    }
}
