using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400NatureArticle
    {
        public string Nature { get; set; }
        public string Designation { get; set; }
        public int? IdFamilleNature { get; set; }

        public virtual _0400FamilleNatureArticle IdFamilleNatureNavigation { get; set; }
    }
}
