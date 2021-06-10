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
        }

        public int IdVille { get; set; }
        public string Ville { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
