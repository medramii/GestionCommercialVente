using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0902BonSortieMagasin
    {
        public _0902BonSortieMagasin()
        {
            _0902BonRetours = new HashSet<_0902BonRetour>();
            _0902DetailBonSortieMagasins = new HashSet<_0902DetailBonSortieMagasin>();
        }

        public string NumBl { get; set; }
        public DateTime? DateBl { get; set; }
        public float? Remise { get; set; }
        public string CodeClient { get; set; }
        public bool? Facturee { get; set; }
        public string CodeMagasin { get; set; }
        public string CodeService { get; set; }
        public string Observation { get; set; }
        public string NumBonCarnet { get; set; }
        public string TypeBs { get; set; }
        public bool? Valider { get; set; }
        public bool? TypeConsommation { get; set; }
        public string TypeProduction { get; set; }
        public bool? Generer { get; set; }
        public string TypeSortie { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreationPar { get; set; }
        public DateTime? ImprerssionDate { get; set; }
        public string ImprerssionPar { get; set; }
        public bool? IsTransfert { get; set; }
        public int? IdBt { get; set; }

        public virtual Client CodeClientNavigation { get; set; }
        public virtual _0400Magasin CodeMagasinNavigation { get; set; }
        public virtual _0107BonTransfert IdBtNavigation { get; set; }
        public virtual ICollection<_0902BonRetour> _0902BonRetours { get; set; }
        public virtual ICollection<_0902DetailBonSortieMagasin> _0902DetailBonSortieMagasins { get; set; }
    }
}
