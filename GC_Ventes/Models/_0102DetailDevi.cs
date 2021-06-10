using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0102DetailDevi
    {
        public int Id { get; set; }
        public string NumDa { get; set; }
        public int? IdDevis { get; set; }
        public string CodeArt { get; set; }
        public string DesignationArt { get; set; }
        public string UniteAch { get; set; }
        public double? Qte { get; set; }
        public double? PrixU { get; set; }
        public double? PrixT { get; set; }
        public string Observation { get; set; }

        public virtual _0102Devi IdDevisNavigation { get; set; }
        public virtual _0102DemandeAchat NumDaNavigation { get; set; }
    }
}
