using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400FamilleArticle
    {
        public _0400FamilleArticle()
        {
            _0400Articles = new HashSet<_0400Article>();
        }

        public string CodeFamille { get; set; }
        public string Designation { get; set; }
        public int? IdGroupe { get; set; }

        public virtual _0400GroupeFamilleArticle IdGroupeNavigation { get; set; }
        public virtual ICollection<_0400Article> _0400Articles { get; set; }
    }
}
