using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400Article
    {
        public _0400Article()
        {
            _0110LigneBonLivraisons = new HashSet<_0110LigneBonLivraison>();
        }

        public int Id { get; set; }
        public string CodeArticle { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<_0110LigneBonLivraison> _0110LigneBonLivraisons { get; set; }
    }
}
