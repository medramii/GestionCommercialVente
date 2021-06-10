using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0108TypeLot
    {
        public _0108TypeLot()
        {
            _0108LotStocks = new HashSet<_0108LotStock>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<_0108LotStock> _0108LotStocks { get; set; }
    }
}
