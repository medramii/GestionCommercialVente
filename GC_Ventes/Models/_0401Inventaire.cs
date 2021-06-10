using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0401Inventaire
    {
        public _0401Inventaire()
        {
            _0401DetailInventaires = new HashSet<_0401DetailInventaire>();
        }

        public int Idinventaire { get; set; }
        public DateTime? DateInv { get; set; }
        public string Justif { get; set; }
        public int? IdPoste { get; set; }
        public string CodeMagasin { get; set; }
        public bool? Valide { get; set; }
        public string CodeInventaire { get; set; }

        public virtual _0400Magasin CodeMagasinNavigation { get; set; }
        public virtual ICollection<_0401DetailInventaire> _0401DetailInventaires { get; set; }
    }
}
