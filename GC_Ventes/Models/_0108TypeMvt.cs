using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0108TypeMvt
    {
        public _0108TypeMvt()
        {
            _0108MvtLotStocks = new HashSet<_0108MvtLotStock>();
        }

        public int Id { get; set; }
        public string TypeMvt { get; set; }
        public int? Coefficient { get; set; }

        public virtual ICollection<_0108MvtLotStock> _0108MvtLotStocks { get; set; }
    }
}
