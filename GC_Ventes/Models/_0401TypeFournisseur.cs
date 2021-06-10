using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0401TypeFournisseur
    {
        public _0401TypeFournisseur()
        {
            _0400Fournisseurs = new HashSet<_0400Fournisseur>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<_0400Fournisseur> _0400Fournisseurs { get; set; }
    }
}
