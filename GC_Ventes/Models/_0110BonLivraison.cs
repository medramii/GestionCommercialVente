using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0110BonLivraison
    {
        public _0110BonLivraison()
        {
            _0110LigneBonLivraisons = new HashSet<_0110LigneBonLivraison>();
        }

        public int Id { get; set; }
        public string NumBl { get; set; }
        public DateTime? DateBl { get; set; }
        public string CodeClient { get; set; }
        public string TypeVente { get; set; }
        public int? IdDestination { get; set; }
        public string Observation { get; set; }
        public double? TauxDeChange { get; set; }
        public double? MontantDh { get; set; }
        public string Devise { get; set; }

        public virtual Client CodeClientNavigation { get; set; }
        public virtual _0000Ville IdDestinationNavigation { get; set; }
        public virtual ICollection<_0110LigneBonLivraison> _0110LigneBonLivraisons { get; set; }
    }
}
