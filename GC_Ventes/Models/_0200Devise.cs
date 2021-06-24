using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0200Devise
    {
        public _0200Devise()
        {
            Clients = new HashSet<Client>();
            _0110BonLivraisons = new HashSet<_0110BonLivraison>();
            _0110FactureComercials = new HashSet<_0110FactureComercial>();
        }

        public int Id { get; set; }
        public string Designation { get; set; }
        public double? TauxDeChange { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<_0110BonLivraison> _0110BonLivraisons { get; set; }
        public virtual ICollection<_0110FactureComercial> _0110FactureComercials { get; set; }
    }
}
