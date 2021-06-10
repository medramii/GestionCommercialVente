using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0103BonCommandeAchat
    {
        public _0103BonCommandeAchat()
        {
            _0103DetailBonCommandeAchats = new HashSet<_0103DetailBonCommandeAchat>();
        }

        public string NumCommande { get; set; }
        public DateTime? DateCommande { get; set; }
        public string CodeFrs { get; set; }
        public bool? Etat { get; set; }
        public bool? Soldee { get; set; }
        public float? Remise { get; set; }
        public string Lieu { get; set; }
        public string CodeModeReg { get; set; }
        public DateTime? DateEcheance { get; set; }
        public string CodeService { get; set; }
        public string Livree { get; set; }
        public int? IdCompteComtabiliteG { get; set; }
        public DateTime? DateLivraison { get; set; }
        public string RefDevisFr { get; set; }
        public string Observation { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreationPar { get; set; }
        public DateTime? ImprerssionDate { get; set; }
        public string ImprerssionPar { get; set; }
        public string ServiceBc { get; set; }
        public string DelaiPaiement { get; set; }
        public string TypeAtct { get; set; }

        public virtual _0400Fournisseur CodeFrsNavigation { get; set; }
        public virtual _1000ModeReglement CodeModeRegNavigation { get; set; }
        public virtual _0000Service CodeServiceNavigation { get; set; }
        public virtual ICollection<_0103DetailBonCommandeAchat> _0103DetailBonCommandeAchats { get; set; }
    }
}
