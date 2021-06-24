using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class Client
    {
        public Client()
        {
            _0110BonLivraisons = new HashSet<_0110BonLivraison>();
            _0110FactureComercials = new HashSet<_0110FactureComercial>();
            _0902BonSortieMagasins = new HashSet<_0902BonSortieMagasin>();
        }

        public string CodeClient { get; set; }
        public string RaisonSociale { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string CodePostal { get; set; }
        public int? IdVille { get; set; }
        public string FormeJuridique { get; set; }
        public string Frs { get; set; }
        public int? IdPays { get; set; }
        public string TypeClient { get; set; }
        public string CaracteristiqueTechnique { get; set; }
        public double? PrixDerContrat { get; set; }
        public DateTime? DateDerContrat { get; set; }
        public int? IdTypeContrat { get; set; }
        public double? Carealisee { get; set; }
        public string IdModReglement { get; set; }
        public string Observation { get; set; }
        public int? IdProduitFini { get; set; }
        public int? IdDevise { get; set; }
        public bool? Bloquer { get; set; }
        public int? IdCompteGeneral { get; set; }
        public int? IdCompteAnalytique { get; set; }

        public virtual _0500ImputationsComptable IdCompteGeneralNavigation { get; set; }
        public virtual _0200Devise IdDeviseNavigation { get; set; }
        public virtual _1000ModeReglement IdModReglementNavigation { get; set; }
        public virtual _0000Ville IdVilleNavigation { get; set; }
        public virtual ICollection<_0110BonLivraison> _0110BonLivraisons { get; set; }
        public virtual ICollection<_0110FactureComercial> _0110FactureComercials { get; set; }
        public virtual ICollection<_0902BonSortieMagasin> _0902BonSortieMagasins { get; set; }
    }
}
