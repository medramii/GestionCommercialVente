using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0500CategorieIputation
    {
        public _0500CategorieIputation()
        {
            _0500ImputationsComptables = new HashSet<_0500ImputationsComptable>();
            _0500PlanComptables = new HashSet<_0500PlanComptable>();
        }

        public int IdCategorie { get; set; }
        public string Compte { get; set; }
        public string Intitule { get; set; }
        public int? IdRubriqueG { get; set; }

        public virtual _0500RubriqueImputationG IdRubriqueGNavigation { get; set; }
        public virtual ICollection<_0500ImputationsComptable> _0500ImputationsComptables { get; set; }
        public virtual ICollection<_0500PlanComptable> _0500PlanComptables { get; set; }
    }
}
