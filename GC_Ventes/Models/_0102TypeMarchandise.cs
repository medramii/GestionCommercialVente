using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0102TypeMarchandise
    {
        public _0102TypeMarchandise()
        {
            _0102DetailDemandeAchats = new HashSet<_0102DetailDemandeAchat>();
            _0103DetailBonCommandeAchats = new HashSet<_0103DetailBonCommandeAchat>();
            _0104DetailBonReceptions = new HashSet<_0104DetailBonReception>();
            _0106DetailBonEntrees = new HashSet<_0106DetailBonEntree>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<_0102DetailDemandeAchat> _0102DetailDemandeAchats { get; set; }
        public virtual ICollection<_0103DetailBonCommandeAchat> _0103DetailBonCommandeAchats { get; set; }
        public virtual ICollection<_0104DetailBonReception> _0104DetailBonReceptions { get; set; }
        public virtual ICollection<_0106DetailBonEntree> _0106DetailBonEntrees { get; set; }
    }
}
