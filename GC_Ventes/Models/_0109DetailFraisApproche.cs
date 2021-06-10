using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0109DetailFraisApproche
    {
        public int Id { get; set; }
        public int IdDetailRptAchat { get; set; }
        public int IdDetailRptFApproche { get; set; }

        public virtual _0104DetailBonReception IdDetailRptAchatNavigation { get; set; }
        public virtual _0104DetailBonReception IdDetailRptFApprocheNavigation { get; set; }
    }
}
