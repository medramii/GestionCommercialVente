using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400GroupeFamilleArticle
    {
        public _0400GroupeFamilleArticle()
        {
            _0400FamilleArticles = new HashSet<_0400FamilleArticle>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<_0400FamilleArticle> _0400FamilleArticles { get; set; }
    }
}
