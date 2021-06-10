using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0400FamilleFournisseur
    {
        public _0400FamilleFournisseur()
        {
            _0400Fournisseurs = new HashSet<_0400Fournisseur>();
        }

        public string CodeFamille { get; set; }
        public string Famille { get; set; }

        public virtual ICollection<_0400Fournisseur> _0400Fournisseurs { get; set; }
    }
}
