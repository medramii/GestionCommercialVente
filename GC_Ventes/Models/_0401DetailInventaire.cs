using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0401DetailInventaire
    {
        public _0401DetailInventaire()
        {
            _0108LotStocks = new HashSet<_0108LotStock>();
        }

        public int IdDetail { get; set; }
        public int Idinventaire { get; set; }
        public string CodeArticle { get; set; }
        public bool? Libirer { get; set; }
        public float? QuantiteTheorique { get; set; }
        public float? QunatitePhysique { get; set; }
        public string Observation { get; set; }
        public float? PrixMoy { get; set; }
        public float? DernierPrixAchat { get; set; }
        public int? IdProduitBrut { get; set; }
        public int? IdProduitSf { get; set; }
        public int? IdProduitFini { get; set; }
        public string TypeArticle { get; set; }
        public double? PrixVenteEstime { get; set; }
        public bool? TypeLot { get; set; }

        public virtual _0401Inventaire IdinventaireNavigation { get; set; }
        public virtual ICollection<_0108LotStock> _0108LotStocks { get; set; }
    }
}
