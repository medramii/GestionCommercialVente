using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0000Tva
    {
        public _0000Tva()
        {
            _0103DetailBonCommandeAchats = new HashSet<_0103DetailBonCommandeAchat>();
            _0104DetailBonReceptions = new HashSet<_0104DetailBonReception>();
            _0105DetailFactureFournisseurs = new HashSet<_0105DetailFactureFournisseur>();
        }

        public float TauxTva { get; set; }

        public virtual ICollection<_0103DetailBonCommandeAchat> _0103DetailBonCommandeAchats { get; set; }
        public virtual ICollection<_0104DetailBonReception> _0104DetailBonReceptions { get; set; }
        public virtual ICollection<_0105DetailFactureFournisseur> _0105DetailFactureFournisseurs { get; set; }
    }
}
