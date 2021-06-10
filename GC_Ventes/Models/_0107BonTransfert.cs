using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0107BonTransfert
    {
        public _0107BonTransfert()
        {
            _0106BonEntrees = new HashSet<_0106BonEntree>();
            _0107DetailBonTransferts = new HashSet<_0107DetailBonTransfert>();
            _0902BonSortieMagasins = new HashSet<_0902BonSortieMagasin>();
        }

        public int Id { get; set; }
        public string NumBt { get; set; }
        public DateTime? DateBt { get; set; }
        public string CreationPar { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ValidationPar { get; set; }
        public DateTime? ValidationDate { get; set; }
        public bool? Valider { get; set; }
        public string Observation { get; set; }
        public string CodeMagasinOrigine { get; set; }
        public string CodeMagasinDestination { get; set; }

        public virtual _0400Magasin CodeMagasinDestinationNavigation { get; set; }
        public virtual _0400Magasin CodeMagasinOrigineNavigation { get; set; }
        public virtual ICollection<_0106BonEntree> _0106BonEntrees { get; set; }
        public virtual ICollection<_0107DetailBonTransfert> _0107DetailBonTransferts { get; set; }
        public virtual ICollection<_0902BonSortieMagasin> _0902BonSortieMagasins { get; set; }
    }
}
