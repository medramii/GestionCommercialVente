using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0500PlanComptable
    {
        public _0500PlanComptable()
        {
            _0500ImputationsComptables = new HashSet<_0500ImputationsComptable>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Intitule { get; set; }
        public int? IdCategorieImputation { get; set; }

        public virtual _0500CategorieIputation IdCategorieImputationNavigation { get; set; }
        public virtual ICollection<_0500ImputationsComptable> _0500ImputationsComptables { get; set; }
    }
}
