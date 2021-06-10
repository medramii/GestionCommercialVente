using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0105FactureFr
    {
        public int Id { get; set; }
        public string NumFacture { get; set; }
        public DateTime? DateFacture { get; set; }
        public string CodeFournisseur { get; set; }
        public double? QteRecu { get; set; }
        public double? QtePayee { get; set; }
        public double? Mnt { get; set; }
        public bool? Validee { get; set; }
        public string TypeFacture { get; set; }
        public double? MntCalcule { get; set; }
        public double? MntFacture { get; set; }
        public DateTime? DateEcheance { get; set; }

        public virtual _0400Fournisseur CodeFournisseurNavigation { get; set; }
    }
}
