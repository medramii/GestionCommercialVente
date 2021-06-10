using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0104QualiteReception
    {
        public _0104QualiteReception()
        {
            _0104DetailBonReceptions = new HashSet<_0104DetailBonReception>();
        }

        public int Id { get; set; }
        public string Qualite { get; set; }

        public virtual ICollection<_0104DetailBonReception> _0104DetailBonReceptions { get; set; }
    }
}
