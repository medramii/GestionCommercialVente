using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0500RubriqueImputationG
    {
        public _0500RubriqueImputationG()
        {
            _0500CategorieIputations = new HashSet<_0500CategorieIputation>();
        }

        public int IdRubriqueG { get; set; }
        public string Code { get; set; }
        public string Intitule { get; set; }

        public virtual ICollection<_0500CategorieIputation> _0500CategorieIputations { get; set; }
    }
}
