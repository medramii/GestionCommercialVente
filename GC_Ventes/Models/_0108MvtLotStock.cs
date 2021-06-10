using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0108MvtLotStock
    {
        public int Id { get; set; }
        public string TypeMvt { get; set; }
        public string CodeMagasin { get; set; }
        public int? IdDetailBonReceptionOrigine { get; set; }
        public int? IdDetailBonEntreeOrigine { get; set; }
        public int? IdDetailBonRetourOrigine { get; set; }
        public int? IdDetailBs { get; set; }
        public int? IdDetailBonEntree { get; set; }
        public int? IdDetailBonRetour { get; set; }
        public double? Qte { get; set; }
        public double? CoutAchat { get; set; }
        public int? IdTypeMvt { get; set; }
        public int? IdLotIventaireOrigine { get; set; }
        public bool? IsLotOrigine { get; set; }

        public virtual _0400Magasin CodeMagasinNavigation { get; set; }
        public virtual _0106DetailBonEntree IdDetailBonEntreeNavigation { get; set; }
        public virtual _0106DetailBonEntree IdDetailBonEntreeOrigineNavigation { get; set; }
        public virtual _0104DetailBonReception IdDetailBonReceptionOrigineNavigation { get; set; }
        public virtual _0902DetailBonRetour IdDetailBonRetourNavigation { get; set; }
        public virtual _0902DetailBonRetour IdDetailBonRetourOrigineNavigation { get; set; }
        public virtual _0902DetailBonSortieMagasin IdDetailBsNavigation { get; set; }
        public virtual _0108TypeMvt IdTypeMvtNavigation { get; set; }
    }
}
