using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0102DemandeAchat
    {
        public _0102DemandeAchat()
        {
            _0102DetailDemandeAchats = new HashSet<_0102DetailDemandeAchat>();
            _0102DetailDevis = new HashSet<_0102DetailDevi>();
            _0103DetailBonCommandeAchats = new HashSet<_0103DetailBonCommandeAchat>();
        }

        public string NumDemande { get; set; }
        public DateTime? DateDemande { get; set; }
        public string CodeService { get; set; }
        public string Lieu { get; set; }
        public string Etat { get; set; }
        public bool? Soldee { get; set; }
        public string CodeFrs { get; set; }
        public string Observation { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreationPar { get; set; }
        public DateTime? ImprerssionDate { get; set; }
        public string ImprerssionPar { get; set; }

        public virtual _0400Fournisseur CodeFrsNavigation { get; set; }
        public virtual _0000Service CodeServiceNavigation { get; set; }
        public virtual ICollection<_0102DetailDemandeAchat> _0102DetailDemandeAchats { get; set; }
        public virtual ICollection<_0102DetailDevi> _0102DetailDevis { get; set; }
        public virtual ICollection<_0103DetailBonCommandeAchat> _0103DetailBonCommandeAchats { get; set; }
    }
}
