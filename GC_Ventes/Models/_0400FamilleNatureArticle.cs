using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400FamilleNatureArticle
    {
        public _0400FamilleNatureArticle()
        {
            _0400NatureArticles = new HashSet<_0400NatureArticle>();
        }

        public int IdFamilleNature { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<_0400NatureArticle> _0400NatureArticles { get; set; }
    }
}
