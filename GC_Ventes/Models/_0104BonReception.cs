using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0104BonReception
    {
        public _0104BonReception()
        {
            _0104DetailBonReceptions = new HashSet<_0104DetailBonReception>();
        }

        public string NumBr { get; set; }
        public DateTime? DateBr { get; set; }
        public string NumBl { get; set; }
        public string CodeFrs { get; set; }
        public string NumBs { get; set; }
        public bool? Etat { get; set; }
        public float? Remise { get; set; }
        public string Observation { get; set; }
        public string CodeService { get; set; }
        public string Facturee { get; set; }
        public string CodeMagasin { get; set; }
        public bool? FraisApproche { get; set; }
        public bool? Valider { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreationPar { get; set; }
        public DateTime? ImprerssionDate { get; set; }
        public string ImprerssionPar { get; set; }
        public string TypeAtct { get; set; }

        public virtual _0400Fournisseur CodeFrsNavigation { get; set; }
        public virtual _0400Magasin CodeMagasinNavigation { get; set; }
        public virtual ICollection<_0104DetailBonReception> _0104DetailBonReceptions { get; set; }
    }
}
