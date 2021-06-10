using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _1000ModeReglement
    {
        public _1000ModeReglement()
        {
            Clients = new HashSet<Client>();
            _0103BonCommandeAchats = new HashSet<_0103BonCommandeAchat>();
            _0105FactureFournisseurs = new HashSet<_0105FactureFournisseur>();
            _0400Fournisseurs = new HashSet<_0400Fournisseur>();
        }

        public string CodeModeReg { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<_0103BonCommandeAchat> _0103BonCommandeAchats { get; set; }
        public virtual ICollection<_0105FactureFournisseur> _0105FactureFournisseurs { get; set; }
        public virtual ICollection<_0400Fournisseur> _0400Fournisseurs { get; set; }
    }
}
