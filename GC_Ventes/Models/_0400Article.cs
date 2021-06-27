using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400Article
    {
        public _0400Article()
        {
            _0106DetailBonEntrees = new HashSet<_0106DetailBonEntree>();
            _0110LigneBonLivraisons = new HashSet<_0110LigneBonLivraison>();
        }

        public int Id { get; set; }
        public string CodeArticle { get; set; }
        public string Designation { get; set; }
        public double? StockAlerte { get; set; }
        public string CodeFamille { get; set; }
        public double? NbrUlivParUachat { get; set; }
        public string UniteAchat { get; set; }
        public string UniteLivraison { get; set; }
        public string Description1 { get; set; }
        public string ModeStock { get; set; }

        public virtual _0400FamilleArticle CodeFamilleNavigation { get; set; }
        public virtual ICollection<_0106DetailBonEntree> _0106DetailBonEntrees { get; set; }
        public virtual ICollection<_0110LigneBonLivraison> _0110LigneBonLivraisons { get; set; }
    }
}
