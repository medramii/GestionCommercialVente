using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0500ImputationsComptable
    {
        public _0500ImputationsComptable()
        {
            Clients = new HashSet<Client>();
            _0102DetailDemandeAchats = new HashSet<_0102DetailDemandeAchat>();
            _0103DetailBonCommandeAchats = new HashSet<_0103DetailBonCommandeAchat>();
            _0104DetailBonReceptions = new HashSet<_0104DetailBonReception>();
            _0105DetailFactureFournisseurs = new HashSet<_0105DetailFactureFournisseur>();
            _0400Fournisseurs = new HashSet<_0400Fournisseur>();
            _0902DetailBonRetours = new HashSet<_0902DetailBonRetour>();
            _0902DetailBonSortieMagasins = new HashSet<_0902DetailBonSortieMagasin>();
        }

        public int IdCompteComtabiliteG { get; set; }
        public double Ncompte { get; set; }
        public string Intitule { get; set; }
        public int? IdCategorie { get; set; }
        public int? IdPlanComptable { get; set; }

        public virtual _0500CategorieIputation IdCategorieNavigation { get; set; }
        public virtual _0500PlanComptable IdPlanComptableNavigation { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<_0102DetailDemandeAchat> _0102DetailDemandeAchats { get; set; }
        public virtual ICollection<_0103DetailBonCommandeAchat> _0103DetailBonCommandeAchats { get; set; }
        public virtual ICollection<_0104DetailBonReception> _0104DetailBonReceptions { get; set; }
        public virtual ICollection<_0105DetailFactureFournisseur> _0105DetailFactureFournisseurs { get; set; }
        public virtual ICollection<_0400Fournisseur> _0400Fournisseurs { get; set; }
        public virtual ICollection<_0902DetailBonRetour> _0902DetailBonRetours { get; set; }
        public virtual ICollection<_0902DetailBonSortieMagasin> _0902DetailBonSortieMagasins { get; set; }
    }
}
