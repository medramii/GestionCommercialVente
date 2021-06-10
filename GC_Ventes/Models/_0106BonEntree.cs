using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0106BonEntree
    {
        public _0106BonEntree()
        {
            _0106DetailBonEntrees = new HashSet<_0106DetailBonEntree>();
        }

        public int Id { get; set; }
        public string NumBe { get; set; }
        public DateTime? DateBe { get; set; }
        public string CodeMagasin { get; set; }
        public string Observation { get; set; }
        public string CreationPar { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ImprerssionDate { get; set; }
        public string ImpressionPar { get; set; }
        public bool? Valider { get; set; }
        public bool? IsTransfert { get; set; }
        public int? IdBt { get; set; }
        public string ValidationPar { get; set; }
        public DateTime? ValidationDate { get; set; }

        public virtual _0400Magasin CodeMagasinNavigation { get; set; }
        public virtual _0107BonTransfert IdBtNavigation { get; set; }
        public virtual ICollection<_0106DetailBonEntree> _0106DetailBonEntrees { get; set; }
    }
}
