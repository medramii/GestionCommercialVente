using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400FamilleArticle
    {
        public string CodeFamille { get; set; }
        public string Designation { get; set; }
        public int? IdGroupe { get; set; }

        public virtual _0400GroupeFamilleArticle IdGroupeNavigation { get; set; }
    }
}
