using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0902BonRetour
    {
        public _0902BonRetour()
        {
            _0902DetailBonRetours = new HashSet<_0902DetailBonRetour>();
        }

        public int Id { get; set; }
        public DateTime? DateRetour { get; set; }
        public string CodeMagasin { get; set; }
        public string NumBon { get; set; }
        public bool? Valider { get; set; }
        public string Observation { get; set; }
        public string NumBl { get; set; }
        public DateTime? DateBonAu { get; set; }
        public DateTime? DateBonDu { get; set; }
        public string TypeBon { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreationPar { get; set; }
        public DateTime? ImprerssionDate { get; set; }
        public string ImprerssionPar { get; set; }

        public virtual _0902BonSortieMagasin NumBlNavigation { get; set; }
        public virtual ICollection<_0902DetailBonRetour> _0902DetailBonRetours { get; set; }
    }
}
