using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0102Devi
    {
        public _0102Devi()
        {
            _0102DetailDevis = new HashSet<_0102DetailDevi>();
            _0103DetailBonCommandeAchats = new HashSet<_0103DetailBonCommandeAchat>();
        }

        public int Id { get; set; }
        public string NumDevis { get; set; }
        public DateTime? DateDevis { get; set; }
        public string CodeFrs { get; set; }
        public string Observation { get; set; }
        public DateTime? DateCreation { get; set; }
        public string CreePar { get; set; }
        public DateTime? DateImpression { get; set; }
        public string ImprimerPar { get; set; }

        public virtual _0400Fournisseur CodeFrsNavigation { get; set; }
        public virtual ICollection<_0102DetailDevi> _0102DetailDevis { get; set; }
        public virtual ICollection<_0103DetailBonCommandeAchat> _0103DetailBonCommandeAchats { get; set; }
    }
}
