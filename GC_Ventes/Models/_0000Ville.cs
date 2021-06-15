using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0000Ville
    {
        public _0000Ville()
        {
            Clients = new HashSet<Client>();
            _0110BonLivraisons = new HashSet<_0110BonLivraison>();
        }

        public int IdVille { get; set; }
        public string Ville { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<_0110BonLivraison> _0110BonLivraisons { get; set; }
    }
}
