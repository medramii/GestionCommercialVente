using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0110FactureComercial
    {
        public _0110FactureComercial()
        {
            _0110BonLivraisons = new HashSet<_0110BonLivraison>();
        }

        public int Id { get; set; }
        public string NumFac { get; set; }
        public DateTime? DateFac { get; set; }
        public DateTime? DateEcheance { get; set; }
        public string CodeClient { get; set; }
        public string CodeModeReg { get; set; }
        public string Observation { get; set; }
        public int? IdDevise { get; set; }
        public double? TauxDeChange { get; set; }
        public double? MontantDh { get; set; }
        public double? MontantDevise { get; set; }

        public virtual Client CodeClientNavigation { get; set; }
        public virtual _1000ModeReglement CodeModeRegNavigation { get; set; }
        public virtual _0200Devise IdDeviseNavigation { get; set; }
        public virtual ICollection<_0110BonLivraison> _0110BonLivraisons { get; set; }
    }
}
